using Centex.Models;
using Centex.Services;
using System.Web.Mvc;

namespace Centex.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var service = new HomeViewModelService();
            return View(service.GetModel());
        }

        public ActionResult Service(int Id)
        {
            var service = new Service();
            return View(service.GetModel((ServiceCategories)Id));
        }

        public ActionResult Product(int Id)
        {
            var service = new ProductService();
            return View(service.GetProduct((ProductCategories)Id));
        }

        [HttpPost]
        public JsonResult SendMessage(Contact message)
        {
            var service = new EmailService();

            service.SendEmail(message);

            return Json("Succes", JsonRequestBehavior.AllowGet);
        }
    }
}