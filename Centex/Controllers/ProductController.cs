using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Centex.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult OverheadCranes()
        {
            return View();
        }

        public ActionResult Overhead_Cranes()
        {
            return View("OverheadCranes");
        }

        public ActionResult PalletRacks()
        {
            return View();
        }

        public ActionResult Pallet_Racks()
        {
            return View("PalletRacks");
        }

        public ActionResult LoadingDockEquipment()
        {
            return View();
        }

        public ActionResult Loading_Dock_Equipment()
        {
            return View("LoadingDockEquipment");
        }

        public ActionResult Shelving()
        {
            return View();
        }

        public ActionResult Converyors()
        {
            return View();
        }

        public ActionResult WarehouseMezzanines()
        {
            return View();
        }

        public ActionResult FallProtectionSystems()
        {
            return View();
        }

        public ActionResult Fall_Protection_Systems()
        {
            return View("FallProtectionSystems");
        }

        public ActionResult DemagDCSPro()
        {
            return View();
        }

        public ActionResult Demag_DCS_Pro()
        {
            return View("DemagDCSPro");
        }

        public ActionResult DemagDCMProManulift()
        {
            return View();
        }

        public ActionResult Demag_DCM_Pro_Manulift()
        {
            return View("DemagDCMProManulift");
        }

        public ActionResult GorbelGforce()
        {
            return View();
        }

        public ActionResult Gorbel_Gforce()
        {
            return View("GorbelGforce");
        }

        public ActionResult PlatformsAndLadders()
        {
            return View();
        }

        public ActionResult Platforms_And_Ladders()
        {
            return View("PlatformsAndLadders");
        }

        public ActionResult ProductSelect()
        {
            return View();
        }
    }
}