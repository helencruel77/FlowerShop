using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloewShopClientView.Controllers
{
    public class FlowerController : Controller
    {
        private readonly IFlowerLogic logic;
        public FlowerController(IFlowerLogic _logic)
        {
            logic = _logic;
        }
        public IActionResult Flowers()
        {
            ViewBag.Flowers = logic.Read(null);
            return View();
        }
    }
}
