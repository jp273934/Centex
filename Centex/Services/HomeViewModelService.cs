using Centex.ViewModels;

namespace Centex.Services
{
    public class HomeViewModelService
    {
        private readonly HomeViewModel _model;

        public HomeViewModelService()
        {
            _model = new HomeViewModel();
        }

        public HomeViewModel GetModel()
        {
            _model.CompanyDescription = "Some of kind of company descriptio";
            _model.BridgeCraneDescription =
                "CMH represents the top crane manufactures in the world. Whether you need a Bridge Cranes (1-125 tons) or Workstation Cranes (150-4000lbs), CMH can supply you with the right crane for your application";
            _model.PalletDescription = "CMH specializes in various types of Pallet racks like Cantilever racking, Clad Rack, Conventional, Drive in, Push back racks.";
            _model.DockDescription = "CMH supplies and installs a full range of dock equipment. Whether your company requires stimple dock bumpers and accessories or a complete in-pit leveler and truck restraint, count on CMH to help you get the right equipment for your needs.";

            return _model;
        }
    }
}