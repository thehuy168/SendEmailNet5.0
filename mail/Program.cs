using System;
using System.Net;
using System.Net.Mail;

namespace mail
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.live.com");
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                NetworkCredential credential = new NetworkCredential("email","password");
                client.EnableSsl = true;
                client.Credentials = credential;
                string from = "email"; //From address 
                string to = "email"; //To address
                MailMessage message = new MailMessage(from, to);
                message.Subject="TestMail";
                message.Body = "<h1> Test Body</h1>";
                message.IsBodyHtml = true;
                client.Send(message);


            }
            catch(Exception)
            {
                throw;
            }

        }
    }
}
