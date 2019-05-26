using Centex.Models;
using Centex.Services.Contact.Interfaces;
using System.Web.Mvc;

namespace Centex.Controllers
{

    public class HomeController : Controller
    {
        private readonly IEmailService _emailService;       

        public HomeController(IEmailService emailService)
        {           
            _emailService = emailService;          
        }

        public ActionResult Index()
        {         
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Service()
        {
            return View();
        }

        public ActionResult Product(int id)
        {
            if(id == 2)
            {
                return RedirectToAction("OverheadCranes", "Product");
            }

            return View();
        }

        public ActionResult PreownedEquipment()
        {
            return View();
        }

        public ActionResult ProductCatalog()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SendMessage(Contact message)
        {
            var firstAddress = "angelo@cmhandling.com";
            var firstName = "Angelo DiMaria";
            var secondAddress = "ross@cmhandling.com";
            var secondName = "Ross Robertson";

            _emailService.SendEmail(message, firstAddress, firstName);
            _emailService.SendEmail(message, secondAddress, secondName);

            return Json("Succes", JsonRequestBehavior.AllowGet);
        }
    }
}