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
    public class OrderLogic : ExceptionHandling, IOrderLogic
    {
        public void CreateOrUpdate(OrderBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                Order element;
                if (model.Id.HasValue)
                {
                    element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                    CheckingElement(element);
                }
                else
                {
                    element = new Order { };
                    context.Orders.Add(element);
                }
                element.BouquetId = model.BouquetId == 0 ? element.BouquetId : model.BouquetId;
                element.ClientId = model.ClientId == 0 ? element.ClientId : model.ClientId;
                element.Count = model.Count;
                element.Sum = model.Sum;
                element.Delivery = model.Delivery;
                element.Status = model.Status;
                element.DateCreate = model.DateCreate;
                element.DateImplement = model.DateImplement;
                context.SaveChanges();
            }
        }
        public void Delete(OrderBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id ==
                        model.Id);
                if (element != null)
                {
                    context.Orders.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    CheckingElement(element);
                }
            }
        }
        public List<OrderViewModel> Read(OrderBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                return context.Orders
                .Where(
                    rec => model == null
                    || (rec.Id == model.Id && model.Id.HasValue)
                    || (model.DateFrom.HasValue && model.DateTo.HasValue && rec.DateCreate >= model.DateFrom && rec.DateCreate <= model.DateTo)
                )
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    BouquetId = rec.BouquetId,
                    ClientId = rec.ClientId,
                    ClientFIO = rec.Client.ClientFIO,
                    Count = rec.Count,
                    Sum = rec.Sum,
                    Status = rec.Status,
                    Delivery = rec.Delivery,
                    DateCreate = rec.DateCreate,
                    DateImplement = rec.DateImplement,
                    BouquetName = rec.Bouquet.BouquetName
                })
                .ToList();
            }
        }
    }
}
