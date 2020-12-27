using BusinessLogic.BindingModels;
using BusinessLogic.Controller;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Implements
{
    public class BouquetLogic : ExceptionHandling, IBouquetLogic
    {
        public void CreateOrUpdate(BouquetBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Bouquet element = context.Bouquets.FirstOrDefault(rec =>
                       rec.BouquetName == model.BouquetName && rec.Id != model.Id);
                        if (model.Id.HasValue)
                        {
                            element = context.Bouquets.FirstOrDefault(rec => rec.Id ==
                           model.Id);
                          
                           CheckingElement(element);
                           
                        }
                        else
                        {
                            element = new Bouquet();
                            context.Bouquets.Add(element);
                        }
                        element.BouquetName = model.BouquetName;
                        element.Price = model.Price;
                        context.SaveChanges();
                        if (model.Id.HasValue)
                        {
                            var flowerBouquets = context.FlowerBouquets.Where(rec
                           => rec.BouquetId == model.Id.Value).ToList();
                            var packagingBouquets = context.PackagingBouquets.Where(rec
                           => rec.BouquetId == model.Id.Value).ToList();
                            // удалили те, которых нет в модели

                          //  context.PackagingBouquets.RemoveRange(packagingBouquets.Where(rec => !model.PackagingBouquets.ContainsKey(rec.BouquetId)).ToList());
                          //  context.FlowerBouquets.RemoveRange(flowerBouquets.Where(rec => !model.FlowerBouquets.ContainsKey(rec.BouquetId)).ToList());
                            context.SaveChanges();
                            // обновили количество у существующих записей
                            foreach (var updateComponent in flowerBouquets)
                            {
                                updateComponent.Count =
                               model.FlowerBouquets[updateComponent.FlowerId].Item2;

                                model.FlowerBouquets.Remove(updateComponent.FlowerId);
                            }
                            foreach (var updateComponent in packagingBouquets)
                            {
                                updateComponent.Count =
                               model.PackagingBouquets[updateComponent.PackagingId].Item2;

                                model.PackagingBouquets.Remove(updateComponent.PackagingId);
                            }
                            context.SaveChanges();
                        }
                        // добавили новые
                        foreach (var pc in model.PackagingBouquets)
                        {
                            context.PackagingBouquets.Add(new PackagingBouquet
                            {
                                BouquetId = element.Id,
                                PackagingId = pc.Key,
                                Count = pc.Value.Item2
                            });
                            context.SaveChanges();
                        }
                        foreach (var pc in model.FlowerBouquets)
                        {
                            context.FlowerBouquets.Add(new FlowerBouquet
                            {
                                BouquetId = element.Id,
                                FlowerId = pc.Key,
                                Count = pc.Value.Item2
                            });
                            context.SaveChanges();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void DeleteFlowerBouquets(BouquetBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (model.Id.HasValue)
                        {
                            context.FlowerBouquets.RemoveRange(context.FlowerBouquets.Where(rec =>  rec.BouquetId == model.Id));

                            context.SaveChanges();
                        }                      
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void DeletePackagingBouquets(BouquetBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (model.Id.HasValue)
                        {
                            context.PackagingBouquets.RemoveRange(context.PackagingBouquets.Where(rec => rec.BouquetId == model.Id));

                            context.SaveChanges();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Delete(BouquetBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.FlowerBouquets.RemoveRange(context.FlowerBouquets.Where(rec =>
                        rec.BouquetId == model.Id));
                        context.PackagingBouquets.RemoveRange(context.PackagingBouquets.Where(rec =>
                       rec.BouquetId == model.Id));
                        Bouquet element = context.Bouquets.FirstOrDefault(rec => rec.Id
                        == model.Id);
                        if (element != null)
                        {
                            context.Bouquets.Remove(element);
                            context.SaveChanges();
                        }
                        else
                            CheckingElement(element);
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public List<BouquetViewModel> Read(BouquetBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                return context.Bouquets
                .Where(rec => model == null || rec.Id == model.Id)
                .ToList()
                .Select(rec => new BouquetViewModel
                {
                    Id = rec.Id,
                    BouquetName = rec.BouquetName,
                    Price = rec.Price,
                    FlowerBouquets = context.FlowerBouquets
                    .Include(recPC => recPC.Flower)
                    .Where(recPC => recPC.BouquetId == rec.Id)
                    .ToDictionary(recPC => recPC.FlowerId, recPC => (recPC.Flower?.FlowerName, recPC.Count)),

                    PackagingBouquets = context.PackagingBouquets
                    .Include(recPC => recPC.Packaging)
                    .Where(recPC => recPC.BouquetId == rec.Id)
                    .ToDictionary(recPC => recPC.PackagingId, recPC => (recPC.Packaging?.PackagingName, recPC.Count))
                })
                .ToList();
            }
        }
    }
}
