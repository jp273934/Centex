using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Centex.Controllers
{
    public class ServiceController : Controller
    {
        public ActionResult InspectionAndRepairs()
        {
            return View();
        }

        public ActionResult LoadTest()
        {
            return View();
        }

        public ActionResult ModernizationAndUpgrades()
        {
            return View();
        }

        public ActionResult PreventativeMaintenance()
        {
            return View();
        }

        public ActionResult Relocation()
        {
            return View();
        }

        public ActionResult ServiceSelect()
        {
            return View();
        }

        public ActionResult Preventative_Maintenance()
        {
            return View("PreventativeMaintenance");
        }

        public ActionResult Inspections_And_Repairs()
        {
            return View("InspectionAndRepairs");
        }

        public ActionResult Load_Test()
        {
            return View("LoadTest");
        }

        public ActionResult Modernization_And_Upgrades()
        {
            return View("ModernizationAndUpgrades");
        }
    }
}