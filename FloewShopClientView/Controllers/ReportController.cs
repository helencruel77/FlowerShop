using BusinessLogic.BusinessLogics;
using BusinessLogic.HelperModels;
using FloewShopClientView.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloewShopClientView.Controllers
{
    public class ReportController : Controller
    {
        private readonly ReportLogic logic;
        private readonly Service service;
        public ReportController(ReportLogic _logic, Service _service)
        {
            logic = _logic;
            service = _service;
        }
        public IActionResult Report()
        {
            var fileName = System.IO.Path.Combine(Environment.CurrentDirectory, "listOrders.xlsx");
            logic.SaveOrdersToExcelFile(Program.Client.Id, fileName);
            service.SendMail(new MailSendInfo
            {
                MailAddress = Program.Client.Email,
                Subject = $"Оформленные заказы",
                Text = $"Ваши заказы",
                FileName = fileName
            });
            return RedirectToAction("Personal", "Client", new { mess = "Отчет отправлен"});
        }
    }
}
