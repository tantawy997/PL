using DAL.Entities;
using System.Net;
using System.Net.Mail;

namespace PL.Helper
{
    public class EmailSettings
    {
        public void SendEmail(Email email)
        {
            var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl= true;
            client.Credentials = new NetworkCredential("abdelrhman.eltantawy97@gmail.com", "tgdoodxqtyluptsa");
            client.Send("abdelrhman.eltantawy97@gmail.com", email.to, email.Subject, email.body);


        }
    }

}
