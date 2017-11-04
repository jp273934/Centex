using Centex.Services.Contact.Interfaces;
using System.Net.Mail;

namespace Centex.Services.Contact
{
    public class EmailService : IEmailService
    {
        public void SendEmail(Models.Contact message, string address, string name)
        {
            var fromAddress = new MailAddress("service@cmhandling.com");
            var toAddress = new MailAddress(address, name);

            const string subject = "PRODUCT/SERVICE INQUARY";
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