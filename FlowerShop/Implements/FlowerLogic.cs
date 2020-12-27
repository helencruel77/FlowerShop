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
    public class FlowerLogic : ExceptionHandling, IFlowerLogic
    {
        public void CreateOrUpdate(FlowerBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                Flower element = context.Flowers.FirstOrDefault(rec => rec.FlowerName == model.FlowerName && rec.Id != model.Id);
                CheckingUniqueness(element);

                if (model.Id.HasValue)
                {
                    element = context.Flowers.FirstOrDefault(rec => rec.Id == model.Id);
                    CheckingElement(element);

                }
                else
                {
                    element = new Flower();
                    context.Flowers.Add(element);
                }
                element.Count = model.Count;
                element.FlowerName = model.FlowerName;
                element.Price = model.Price;
                context.SaveChanges();
            }
        }

        public void Delete(FlowerBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                Flower element = context.Flowers.FirstOrDefault(rec => rec.Id == model.Id);

                if (element != null)
                {
                    context.Flowers.Remove(element);
                    context.SaveChanges();
                }
                else
                    CheckingElement(element);

            }
        }

        public void FlowersRefill(RequestFlowersBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                RequestFlowers element = context.RequestsFlowers.FirstOrDefault(rec => rec.RequestId == model.RequestId && rec.FlowerId == model.FlowerId);

                if (element == null)
                {
                    context.RequestsFlowers.Add(new RequestFlowers
                    {
                        FlowerId = model.FlowerId,
                        RequestId = model.RequestId,
                        Count = model.Count
                    });
                }
                context.Flowers.FirstOrDefault(res => res.Id == model.FlowerId).Count += model.Count;
                context.SaveChanges();
            }
        }

        public List<FlowerViewModel> Read(FlowerBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                return context.Flowers
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new FlowerViewModel
                {
                    Id = rec.Id,
                    FlowerName = rec.FlowerName,
                    Count = rec.Count,
                    Price = rec.Price
                })
                .ToList();
            }
        }
    }
}
