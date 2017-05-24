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

        public ActionResult Service()
        {
            return View();
        }

        public ActionResult Product(int Id)
        {
            var service = new ProductService();
            return View(service.GetProduct((ProductCategories)Id));
        }
    }
}