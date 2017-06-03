using Centex.Models;
using System.Net.Mail;

namespace Centex.Services
{
    public class EmailService
    {
        public void SendEmail(Contact message)
        {
            var fromAddress = new MailAddress("jparris195@gmail.com", "Jeremy Parris");
            var toAddress = new MailAddress("jparris195@gmail.com", "Jeremy Parris");

            //const string fromPassword = "gamer37man";
            const string subject = "Centext website test message";
            string body = "<b>Name : <b>" + message.FirstName + " " + message.LastName + "<br/>" +
                          "<b>Email : </b>" + message.Email + "<br/>" +
                          "<b>Address : </b>" + message.AddressOne + "<br/>" + 
                          "<b>Message : </b>" + message.Message;

            var smtp = new SmtpClient();

            using (var email = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
            {
                smtp.Send(email);
            }
        }
    }
}