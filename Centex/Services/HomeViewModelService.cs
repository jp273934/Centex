using Centex.Models;
using Centex.ViewModels;
using System.Collections.Generic;

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
            _model.Panels = GetPanels();
            return _model;
        }

        private IEnumerable<Panel> GetPanels()
        {
            var panels = new List<Panel>
            {
                new Panel
                {
                    Title = "Pallet Rack",
                    Description = "CMH specializes in various types of Pallet racks like Cantilever racking, Clad Rack, Conventional, Drive in, Push back racks.",
                    ImagePath = "Images/Pallet.jpg"
                },
                new Panel
                {
                    Title = "Bridge Cranes",
                    Description = "CMH represents the top crane manufactures in the world. Whether you need a Bridge Cranes (1-125 tons) or Workstation Cranes (150-4000lbs), CMH can supply you with the right crane for your application",
                    ImagePath = "Images/bridgecrane.jpg"
                }
            };

            return panels;
        }
    }
}