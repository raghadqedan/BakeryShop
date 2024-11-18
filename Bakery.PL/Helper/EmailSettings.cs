using Bakery.DAL.Models;
using System.Net;
using System.Net.Mail;

namespace Bakery.PL.Helper
{
    public class EmailSettings
    {

        public static  void SendEmail (Email email)
        {
           
                var client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("raghadwasef@gmail.com", "11111");
                client.Send("raghadwasef@gmail.com", email.Recivers, email.Subject, email.Boady);
          
        }
    }
}
