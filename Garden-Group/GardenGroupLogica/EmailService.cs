using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupLogica
{
    public class EmailService
    {

        /*SmtpClient smtpClient = new SmtpClient("smtp.mailtrap.io")
        {
            Port = 2525,
            Credentials = new NetworkCredential("ab72e98e4fead6", "09b21e1738af1c"),
            EnableSsl = true,
        };*/

        SmtpClient smtpClient = new SmtpClient {
            Host = "smtp.gmail.com",
            Port = 587  ,
            EnableSsl = true,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("thegardengroup2022@gmail.com", "zikrtrbynyrbokpl")
    };

    public void SendPassword(string recipient, string password)
        {
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("thegardengroup2022@gmail.com"),
                Subject = "Your new TheGardenGroup account!",
                Body = $"" +
                $"" +
                $"<h1>Er is een account voor je aangemaakt.</h1>" +
                $"<p>Password: {password}</p> Dit is uw nieuwe wachtwoord.",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(recipient);

            smtpClient.Send(mailMessage);




        }

        public void SendCode(string recipient, string code) {
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("thegardengroup2022@gmail.com"),
                Subject = "Your code for password reset.",
                Body = $"" +
                $"" +
                $"<h1>Hier is de code voor het wijzigen van uw wachtwoord.</h1>" +
                $"<p>code: {code}</p> Dit is uw wijzigingscode.",
                IsBodyHtml = true,
            };

            mailMessage.To.Add(recipient);

            smtpClient.Send(mailMessage);

        }
            

        public void SendTicketToEmail(string recipient, Ticket ticket)
        {
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("thegardengroup2022@gmail.com"),
                Subject = "Nieuwe ticket",
                Body = $"<h2>Er is een nieuwe ticket aangemaakt:</h2>" +
                $"<p>{ticket.Title} met beschrijving: {ticket.Description}</p>" +
                $"<p>Deze zojuist aangemaakte ticket is terug te vinden in uw account. </p>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(recipient);

            smtpClient.Send(mailMessage);
        }
    }
}
