using Centex.Models;
using Centex.Services.Contact;
using System.Web.Http;

namespace Centex.Controllers.api
{
    public class EmailController : ApiController
    {
       
        [HttpPost]
        public IHttpActionResult SendEmail([FromBody]Contact message)
        {
            var service = new EmailService();

            var firstAddress = "angelo@cmhandling.com";
            var firstName = "Angelo DiMaria";
            var secondAddress = "ross@cmhandling.com";
            var secondName = "Ross Robertson";

            service.SendEmail(message, firstAddress, firstName);
            service.SendEmail(message, secondAddress, secondName);

            return Ok();
        }
    }
}
