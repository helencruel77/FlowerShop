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
    public class RequestLogic : ExceptionHandling, IRequestLogic
    {
        public void CreateOrUpdate(RequestBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                Request element = context.Requests.FirstOrDefault(rec => rec.RequestName == model.RequestName && rec.Id != model.Id);
                if (model.Id.HasValue)
                {
                    element = context.Requests.FirstOrDefault(rec => rec.Id == model.Id);
                    CheckingElement(element);

                }
                else
                {
                    element = new Request();
                    context.Requests.Add(element);
                }

                element.RequestName = model.RequestName;
                element.DateCreate = model.DateCreate;

                context.SaveChanges();
            }
        }

        public void Delete(RequestBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.RequestsFlowers.RemoveRange(context.RequestsFlowers.Where(rec => rec.RequestId == model.Id));
                        Request element = context.Requests.FirstOrDefault(rec => rec.Id == model.Id);

                        if (element != null)
                        {
                            context.Requests.Remove(element);
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

        public List<RequestViewModel> Read(RequestBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                return context.Requests
             .Where(rec => model == null || rec.Id == model.Id || rec.DateCreate > model.DateFrom && rec.DateCreate < model.DateTo)
             .ToList()
             .Select(rec => new RequestViewModel
             {
                 Id = rec.Id,
                 RequestName = rec.RequestName,
                 DateCreate = rec.DateCreate,
                 RequestsFlowers = context.RequestsFlowers
                                             .Include(recWC => recWC.Flower)
                                             .Where(recWC => recWC.RequestId == rec.Id)
                                             .ToDictionary(recWC => recWC.FlowerId, recWC => (
                                                 recWC.Flower?.FlowerName, recWC.Count
                                             ))
             })
             .ToList();
            }
        }

        public void AddFlower(RequestFlowersBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                RequestFlowers element =
                    context.RequestsFlowers.FirstOrDefault(rec => rec.RequestId == model.RequestId && rec.FlowerId == model.FlowerId);
                
                if (element != null && element.FlowerId == model.FlowerId)
                {
                    element.Count += model.Count;
                }
                else
                {

                    element = new RequestFlowers();
                    context.RequestsFlowers.Add(element);
                    element.RequestId = model.RequestId;
                    element.FlowerId = model.FlowerId;
                    element.Count = model.Count;
                }
                context.SaveChanges();
            }
        }
    }
}
