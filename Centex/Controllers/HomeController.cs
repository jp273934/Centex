using Centex.Services;
using Centex.ViewModels;
using System.Web.Mvc;

namespace Centex.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeViewModel _model;

        public HomeController()
        {
            var service = new HomeViewModelService();
            _model = service.GetModel();
        }

        public ActionResult Index()
        {
            
            return View(_model);
        }

        public ActionResult Service()
        {
            return View();
        }
    }
}