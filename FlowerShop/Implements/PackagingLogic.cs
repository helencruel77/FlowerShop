using BusinessLogic.BindingModels;
using BusinessLogic.Controller;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Implements
{
    public class PackagingLogic : ExceptionHandling, IPackagingLogic
    {
        public void CreateOrUpdate(PackagingBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                Packaging element = context.Packagings.FirstOrDefault(rec => rec.PackagingName == model.PackagingName && rec.Id != model.Id);

                CheckingUniqueness(element);

                if (model.Id.HasValue)
                {
                    element = context.Packagings.FirstOrDefault(rec => rec.Id == model.Id);                
                    CheckingElement(element);

                }
                else
                {
                    element = new Packaging();
                    context.Packagings.Add(element);
                }
                element.Count = model.Count;
                element.PackagingName = model.PackagingName;
                element.Price = model.Price;
                context.SaveChanges();
            }
        }

        public void Delete(PackagingBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                Packaging element = context.Packagings.FirstOrDefault(rec => rec.Id == model.Id);

                if (element != null)
                {
                    context.Packagings.Remove(element);
                    context.SaveChanges();
                }
                else
                    CheckingElement(element);

            }
        }

         
        public List<PackagingViewModel> Read(PackagingBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                return context.Packagings
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new PackagingViewModel
                {
                    Id = rec.Id,
                    PackagingName = rec.PackagingName,
                    Count = rec.Count,
                    Price = rec.Price
                })
                .ToList();
            }
        }
    }
}