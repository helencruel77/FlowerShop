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
    public class ClientLogic : ExceptionHandling, IClientLogic
    {
        public void CreateOrUpdate(ClientBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                Client element = model.Id.HasValue ? null : new Client();

                if (model.Id.HasValue)
                {
                    element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);

                    CheckingElement(element);
                }
                else
                {
                    element = new Client();
                    context.Clients.Add(element);
                }
                element.ClientFIO = model.ClientFIO;
                element.Password = model.Password;
                element.Email = model.Email ?? element.Email;
                context.SaveChanges();
            }
        }

        public void Delete(ClientBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                Client element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);

                if (element != null)
                {
                    context.Clients.Remove(element);
                    context.SaveChanges();
                }
                else
                    CheckingElement(element);
            }
        }

        public List<ClientViewModel> Read(ClientBindingModel model)
        {
            using (var context = new FlowerShopDatabase())
            {
                return context.Clients
                .Where(rec => model == null
                   || (rec.Id == model.Id)
                   || (rec.Email == model.Email || rec.Email == model.Email)
                       && (model.Password == null || rec.Password == model.Password))
                .Select(rec => new ClientViewModel
                {
                    Id = rec.Id,
                    ClientFIO = rec.ClientFIO,
                    Email = rec.Email,
                    Password = rec.Password
                })
                .ToList();
            }
        }
    }
}
