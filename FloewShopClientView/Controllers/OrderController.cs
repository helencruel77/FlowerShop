using BusinessLogic.BindingModels;
using BusinessLogic.Enums;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using FloewShopClientView.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloewShopClientView.Controllers
{
    public class OrderController : Controller
    {
        private readonly IBouquetLogic Blogic;
        private readonly IOrderLogic logic;
        // GET: ClientController
        public OrderController(IOrderLogic _logic, IBouquetLogic _Blogic)
        {
            logic = _logic;
            Blogic = _Blogic;
        }
        [HttpGet]
        public ActionResult Order(int id)
        {
            ViewBag.Id = id;
            BouquetViewModel product = Blogic.Read(new BouquetBindingModel
            {
                Id =
                    id
            })?[0];
            ViewBag.BouquetName = product.BouquetName;
            ViewBag.Price = product.Price;
            ViewBag.Sum = product.Price;
            return View();
        }
        [HttpPost]
        public ViewResult Order(OrderModel model, int BouquetId)
        {
            BouquetViewModel product = Blogic.Read(new BouquetBindingModel
            {
                Id = BouquetId
            })?[0];
            ViewBag.BouquetName = product.BouquetName;
            ViewBag.Price = product.Price * model.Count;
            logic.CreateOrUpdate(new OrderBindingModel
            {
                ClientId = Program.Client.Id,
                BouquetId = BouquetId,
                Count = model.Count,
                Delivery = model.DeliveryType,
                Sum = product.Price* model.Count,
                DateCreate = DateTime.Now,
                Status = OrderStatus.Принят
            });
            ModelState.AddModelError("", "Заказ оформлен");
            return View("Order",model);
        }
    }
}