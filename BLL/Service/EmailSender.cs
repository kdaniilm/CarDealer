using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using BLL.Infrastructure;
using BLL.Service.Interfaces;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace BLL.Service
{
   public class EmailSender:IEmailSender
   {
      
       public async Task SendEmailAsync(string userEmail, string subject, string htmlMessage)
       {
            MailAddress from = new MailAddress("kdaniilm@gmail.com", "CarDealer");

            MailAddress to = new MailAddress(userEmail);

            MailMessage message = new MailMessage(from, to);

            message.Subject = "Тест";

            message.Body = subject + htmlMessage;

            message.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.Credentials = new NetworkCredential("kdaniilm@gmail.com", "Danchikus2000");

            smtp.EnableSsl = true;
            smtp.Send(message);
        }
    }
}
