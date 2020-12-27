using BusinessLogic.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FloewShopClientView
{
    public class Service
    {
        public void SendMail(MailSendInfo info)
        {
            MailMessage objMailMessage = new MailMessage();
            objMailMessage.IsBodyHtml = true;
            objMailMessage.From = new MailAddress("helen.razinova@gmail.com", "Цветочная мастерская");
            objMailMessage.To.Add(new MailAddress(info.MailAddress));
            objMailMessage.Subject = info.Subject;
            objMailMessage.Body = info.Text;
            if (info.FileName != null)
            {
                objMailMessage.Attachments.Add(new Attachment(info.FileName));
            }
            

            using (SmtpClient client = new SmtpClient("smtp.gmail.com",587))
            {
                client.Credentials = new NetworkCredential("helen.razinova@gmail.com", "awakeawake397365");
                client.EnableSsl = true;
                client.Send(objMailMessage);

            }
        }
    }
}
