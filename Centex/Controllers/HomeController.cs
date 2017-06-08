using Centex.Models;
using Centex.Services.Catalog.Interfaces;
using Centex.Services.Contact.Interfaces;
using Centex.Services.Home.Interfaces;
using Centex.Services.Products;
using Centex.Services.Products.Interfaces;
using Centex.Services.ServiceObjects;
using Centex.Services.ServiceObjects.Interfaces;
using System.Web.Mvc;

namespace Centex.Controllers
{

    public class HomeController : Controller
    {
        private readonly IHomeViewModelService _homeViewModelService;
        private readonly IService _service;
        private readonly IProductService _productService;
        private readonly IEmailService _emailService;
        private readonly ICatalogService _catalogService;

        public HomeController(IHomeViewModelService homeViewModelService, IService service, IProductService productService, IEmailService emailService, ICatalogService catalogService)
        {
            _homeViewModelService = homeViewModelService;
            _service = service;
            _productService = productService;
            _emailService = emailService;
            _catalogService = catalogService;
        }

        public ActionResult Index()
        {
            return View(_homeViewModelService.GetModel());
        }

        public ActionResult Service(int Id)
        {
            return View(_service.GetModel((ServiceCategories)Id));
        }

        public ActionResult Product(int Id)
        {
            return View(_productService.GetProduct((ProductCategories)Id));
        }

        public ActionResult Catalog(int Id)
        {
            return View(_catalogService.GetCataLogItemById(Id));
        }

        [HttpPost]
        public JsonResult SendMessage(Contact message)
        {
            _emailService.SendEmail(message);

            return Json("Succes", JsonRequestBehavior.AllowGet);
        }
    }
}