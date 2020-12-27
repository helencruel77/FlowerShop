using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloewShopClientView.Controllers
{
    public class PackingController : Controller
    {
        private readonly IPackagingLogic logic;
        public PackingController(IPackagingLogic _logic)
        {
            logic = _logic;
        }
        public IActionResult Packings()
        {
            ViewBag.Packings = logic.Read(null);
            return View();
        }
    }
}
