using Centex.Models;
using Centex.Services;
using Centex.Services.Catalog.Interfaces;
using Centex.Services.Contact.Interfaces;
using Centex.Services.Home.Interfaces;
using Centex.Services.ServiceObjects;
using Centex.Services.ServiceObjects.Interfaces;
using System.Web.Mvc;

namespace Centex.Controllers
{

    public class HomeController : Controller
    {
        private readonly IHomeViewModelService _homeViewModelService;
        private readonly IService _service;
        private readonly IEmailService _emailService;
        private readonly ICatalogService _catalogService;
        private readonly IItemViewService _itemViewService;

        public HomeController(IHomeViewModelService homeViewModelService, IService service, IEmailService emailService, ICatalogService catalogService, IItemViewService itemViewService)
        {
            _homeViewModelService = homeViewModelService;
            _service = service;
            _emailService = emailService;
            _catalogService = catalogService;
            _itemViewService = itemViewService;
        }

        public ActionResult Index()
        {
            var model = _homeViewModelService.GetModel();
            return View(_homeViewModelService.GetModel());
        }

        public ActionResult Service(int Id)
        {
            return View(_service.GetModel((ServiceCategories)Id));
        }

        public ActionResult Product(int Id)
        {
            var model = _itemViewService.GetViewModel(Categories.ItemType.Product, Id);
            return View(model);
        }

        public ActionResult Catalog(int Id)
        {
            return View(_catalogService.GetCataLogItemById(Id));
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SendMessage(Contact message)
        {
            _emailService.SendEmail(message);

            return Json("Succes", JsonRequestBehavior.AllowGet);
        }
    }
}