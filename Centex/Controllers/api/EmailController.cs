using Centex.Models;
using Centex.Services;
using System.Web.Http;

namespace Centex.Controllers.api
{
    public class EmailController : ApiController
    {
       
        [HttpPost]
        public IHttpActionResult SendEmail([FromBody]Contact message)
        {
            var service = new EmailService();

            service.SendEmail(message);

            return Ok();
        }
    }
}
