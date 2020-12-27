using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using FloewShopClientView.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloewShopClientView.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientLogic logic;
        // GET: ClientController
        public ClientController(IClientLogic client)
        {
            logic = client;
        }
        public ActionResult Personal(string mess)
        {
            ViewBag.User = Program.Client;
            if (mess != null)
            {
                ModelState.AddModelError("", mess);
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel client)
        {
            if (ModelState.IsValid)
            {
                var clientView = logic.Read(new ClientBindingModel
                {
                    Email = client.Email,
                    Password = client.Password
                }).FirstOrDefault();
                if (clientView == null)
                {
                    ModelState.AddModelError("", "Вы ввели неверный пароль, либо пользователь не найден");
                    return View(client);
                }
                Program.Client = clientView;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult Logout()
        {
            Program.Client = null;
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Registration(RegistrationModel client)
        {
            if (ModelState.IsValid)
            {
                var existClient = logic.Read(new ClientBindingModel
                {
                    Email = client.Email
                }).FirstOrDefault();
                if (existClient != null)
                {
                    ModelState.AddModelError("", "Данный E-Mail уже занят");
                    return View(client);
                }
                logic.CreateOrUpdate(new ClientBindingModel
                {
                    ClientFIO = client.ClientFIO,
                    Password = client.Password,
                    Email = client.Email
                });
                ModelState.AddModelError("", "Вы успешно зарегистрированы");
            }
            return View("Registration", client);
        }
        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public ViewResult ChangePassword(ChangePasswordModel client)
        {
            if (ModelState.IsValid) { 

                if (client.OldPassword == client.NewPassword)
                {
                    ModelState.AddModelError("", "Пожалуйста, придумайте пароль, которые вы ранее не использовали"); 
                    return View();
                }
                if (client.OldPassword == Program.Client.Password)
                {
                    logic.CreateOrUpdate(new ClientBindingModel
                    {
                        Id = Program.Client.Id,
                        ClientFIO = Program.Client.ClientFIO,
                        Password = client.NewPassword,
                        Email = Program.Client.Email
                    });
                    ModelState.AddModelError("", "Пароль успешно изменен");
                }
                else
                {
                    ModelState.AddModelError("", "Старый пароль неверный");
                }
            }
           
            return View("ChangePassword", client);
        }
    }
}
