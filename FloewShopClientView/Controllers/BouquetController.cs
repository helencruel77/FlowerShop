using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using FloewShopClientView.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloewShopClientView.Controllers
{
    public class BouquetController : Controller
    {
        private readonly IFlowerLogic _FLogic;
        private readonly IPackagingLogic _PLogic;
        private readonly IBouquetLogic logic;
        List<FlowerBouquetBindingModel> orderFlowers = new List<FlowerBouquetBindingModel>();
        Dictionary<int, (string, int)> dictFlowers = new Dictionary<int, (string, int)>();
        Dictionary<int, (string, int)> dictPackings = new Dictionary<int, (string, int)>();
        List<PackingBouquetBindingModel> orderPackings = new List<PackingBouquetBindingModel>();

        public BouquetController(IBouquetLogic _logic, IFlowerLogic flowerLogic, IPackagingLogic pacLogic)
        {
            _PLogic = pacLogic;
            _FLogic = flowerLogic;
            logic = _logic;
        }
        public ActionResult Bouquet(string mess)
        {
            List <BouquetViewModel> list = logic.Read(null);
            list.Reverse();
            ViewBag.Bouquets = list;
            if (mess != null)
            {
                ModelState.AddModelError("", mess);
            }
            return View();
        }
        public ActionResult BouquetName()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateBouquet(string BouquetName, string error)
        {
            ViewBag.FlowerBouquets = _FLogic.Read(null);
            ViewBag.PackagingBouquets = _PLogic.Read(null);
            ViewBag.BouquetName = BouquetName;
            if (error != null)
            {
                ModelState.AddModelError("", error);
            }
            
            return View();
        }
        [HttpPost]
        public ActionResult CreateBouquet(CreateBouquetModel model, string BouquetName)
        {
            string name = BouquetName;
            int flag = 0;
            ViewBag.FlowerBouquets = _FLogic.Read(null);
            ViewBag.PackagingBouquets = _PLogic.Read(null);
            foreach (var flower in model.FlowerBouquets)
            {
                if (flower.Value > 0 || flag == 1)
                {
                    flag = 1;
                    orderFlowers.Add(new FlowerBouquetBindingModel
                    {
                        Id = flower.Key,
                        FlowerId = flower.Key,
                        BouquetId = flower.Key,
                        Count = flower.Value,
                    });
                }
                else
                {
                    return RedirectToAction("CreateBouquet", "Bouquet", new {BouquetName = BouquetName, error = "Выберите все комплектующие" });
                }
            }
            foreach (var pack in model.PackagingBouquets)
            {
                if (pack.Value > 0 || flag == 0)
                {
                    flag = 0;
                    orderPackings.Add(new PackingBouquetBindingModel
                    {
                        Id = pack.Key,
                        PackingId = pack.Key,
                        BouquetId = pack.Key,
                        Count = pack.Value,
                    });
                }
                else
                {
                    return RedirectToAction("CreateBouquet", "Bouquet", new { BouquetName = BouquetName, error = "Выберите все комплектующие" });
                }
            }
            foreach (var elem in orderFlowers)
            {
                dictFlowers.Add(elem.Id, (elem.FlowerId.ToString(), elem.Count));
            }

            foreach (var elem in orderPackings)
            {
                dictPackings.Add(elem.Id, (elem.PackingId.ToString(), elem.Count));
            }

            logic.CreateOrUpdate(new BouquetBindingModel
            {
                Price = CalculateSum(orderFlowers, orderPackings),
                BouquetName = name,
                PackagingBouquets = dictPackings,
                FlowerBouquets = dictFlowers
            });
            

            return RedirectToAction("Bouquet", "Bouquet", new { mess = "Букет " + name + " успешно создан"});
        }
        private int CalculateSum(List<FlowerBouquetBindingModel> orderFlowers, List<PackingBouquetBindingModel> orderPackings)
        {
            int sum = 0;

            foreach (var flower in orderFlowers)
            {
                var flowerData = _FLogic.Read(new FlowerBindingModel { Id = flower.FlowerId }).FirstOrDefault();

                if (flowerData != null)
                {
                    for (int i = 0; i < flower.Count; i++)
                        sum += (int)flowerData.Price;
                }
            }
            foreach (var pack in orderPackings)
            {
                var packData = _PLogic.Read(new PackagingBindingModel { Id = pack.PackingId }).FirstOrDefault();

                if (packData != null)
                {
                    for (int i = 0; i < pack.Count; i++)
                        sum += (int)packData.Price;
                }
            }
            return sum;
        }

    }
}
