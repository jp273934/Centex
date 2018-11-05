﻿using Centex.Models;
using Centex.Services;
using Centex.Services.Catalog.Interfaces;
using Centex.Services.Contact.Interfaces;
using Centex.Services.Home.Interfaces;
using Centex.Services.ServiceObjects;
using Centex.Services.ServiceObjects.Interfaces;
using System.Collections.Generic;
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

        public ActionResult UsedEquipment()
        {
            var rootPath = "/Images/UsedEquipment/WildeckMezzanine/";

            var descriptions = new List<ServiceDescription>
            {
                new ServiceDescription
                {
                    Description = "75’ x 40’ overall (2400 Sq. Ft. of usable space)"
                },
                new ServiceDescription
                {
                    Description = "Guard Rail on 2 sides"
                },
                new ServiceDescription
                {
                    Description = "Powered Gate"
                },
                new ServiceDescription
                {
                    Description = "Bar Grated Decking"
                }
            };
            var model = new ServiceModel
            {
                Id = 0,
                Title = "Wildeck Mezzanine",
                Descriptions = descriptions,
                Images = new List<string>
                {
                    rootPath + "20180306_094850.jpg",
                    rootPath + "20180306_094918.jpg",
                    rootPath + "20180306_094923.jpg"
                }
            };

            return View("Service" , model);
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

        public ActionResult PlatformsLadders()
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