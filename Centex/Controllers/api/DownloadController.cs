using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Centex.Controllers.api
{
    public class DownloadController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Download()
        {
            HttpResponseMessage result = null;
            var localPath = HttpContext.Current.Server.MapPath("~/Brochures/DemagProBrochure.pdf");

            if(!File.Exists(localPath))
            {
                result = Request.CreateResponse(HttpStatusCode.Gone);
            } else
            {
                result = Request.CreateResponse(HttpStatusCode.OK);
                result.Content = new StreamContent(new FileStream(localPath, FileMode.Open, FileAccess.Read));
                result.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                result.Content.Headers.ContentDisposition.FileName = "DemagProBrochure.pdf";
            }

            return result;
        }
    }
}
