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
                    Id = 0,
                    Title = "Cranes",
                    Description = "CMH specializes in various types of Pallet racks like Cantilever racking, Clad Rack, Conventional, Drive in, Push back racks.",
                    ImagePath = "/Images/Logos/crane.png"
                },
                new Panel
                {
                    Id = 1,
                    Title = "Pallet Racks",
                    Description = "CMH represents the top crane manufactures in the world. Whether you need a Bridge Cranes (1-125 tons) or Workstation Cranes (150-4000lbs), CMH can supply you with the right crane for your application",
                    ImagePath = "/Images/Logos/PalletRockLogo.png"
                },
                new Panel
                {
                    Id = 2,
                    Title = "Loading Dock Equipment",
                    Description = "CMH supplies and installs a full range of dock equipment. Whether your company requires simple dock bumpers and accessories or a complete in-pit leveler and truck restraint, count on CMH to help you get the right equipment for your needs.",
                    ImagePath = "/Images/Logos/loadingdock.png"                },
                new Panel
                {
                    Id = 3,
                    Title = "Shelvings",
                    Description = "Recycling equipment description",
                    ImagePath = "/Images/Logos/shelving.png"                },
                new Panel
                {
                    Id = 4,
                    Title = "Conveyors",
                    Description = "Wire shelvings description",
                    ImagePath = "/Images/Logos/PalletRockLogo.png"                },
                new Panel
                {
                    Id = 5,
                    Title = "Warehouse Mezzanines",
                    ImagePath = "/Images/Logos/PalletRockLogo.png"
                }
            };

            return panels;
        }
    }
}