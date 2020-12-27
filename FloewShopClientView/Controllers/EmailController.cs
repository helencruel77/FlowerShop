using BusinessLogic.HelperModels;
using BusinessLogic.Interfaces;
using FloewShopClientView.Models;
using Microsoft.AspNetCore.Mvc;

namespace FloewShopClientView.Controllers
{
    public class EmailController : Controller
    {
        private readonly IClientLogic logic;
        private readonly Service service;
        public EmailController(Service _service, IClientLogic _logic)
        {
            logic = _logic;
            service = _service;
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public ViewResult ForgotPassword(EmailModel model)
        {
            if (ModelState.IsValid)
            {
                var clientsEmails = logic.Read(null);
                foreach (var clientEmail in clientsEmails)
                {
                    if (model.mail == clientEmail.Email)
                    {
                        service.SendMail(new MailSendInfo
                        {
                            MailAddress = model.mail,
                            Subject = $"Восстановление пароля",
                            Text = $"Ваш пароль:" + clientEmail.Password,
                            FileName = null
                        });
                        ViewBag.Id = 1;
                    }

                }
                if (ViewBag.Id == 1)
                {
                    ModelState.AddModelError("", "Письмо отправлено на указанную почту");
                    return View("ForgotPassword");
                }
                else
                {
                    ModelState.AddModelError("", "Данная почта не зарегестрирована");
                }
            }
            return View("ForgotPassword", model);
        }
    }
}
