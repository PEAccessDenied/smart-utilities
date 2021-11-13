
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering
{
    public class Emailer
    {
        public static async Task Send(string to, string subject, string body, bool isBodyHtml)
        {
            MailAddress toEmail = new MailAddress(to);
            MailAddress from = new MailAddress("no-reply@developmenthub.co.za", "Ubiquitous 360 Mailer");
            MailMessage mail = new MailMessage(from, toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = isBodyHtml
            };

            SmtpClient smtp = new SmtpClient
            {
                EnableSsl = false,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("e071e6154a395432f684870462d79b3b", "2ffb7c12579fa0afbcb1d792fc4d0f3f"),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Port = 587,
                Host = "in-v3.mailjet.com"
            };
            await smtp.SendMailAsync(mail);
        }
    }
}
