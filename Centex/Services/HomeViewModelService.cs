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
                    Id = 1,
                    Title = "Pallet Rack",
                    Description = "CMH specializes in various types of Pallet racks like Cantilever racking, Clad Rack, Conventional, Drive in, Push back racks.",
                    ImagePath = "/Images/Pallet.jpg"
                },
                new Panel
                {
                    Id = 0,
                    Title = "Bridge Cranes",
                    Description = "CMH represents the top crane manufactures in the world. Whether you need a Bridge Cranes (1-125 tons) or Workstation Cranes (150-4000lbs), CMH can supply you with the right crane for your application",
                    ImagePath = "/Images/bridgecrane.jpg"
                },
                new Panel
                {
                    Id = 2,
                    Title = "Dock Levers",
                    Description = "CMH supplies and installs a full range of dock equipment. Whether your company requires simple dock bumpers and accessories or a complete in-pit leveler and truck restraint, count on CMH to help you get the right equipment for your needs.",
                    ImagePath = "/Images/Main_Desc.png"
                },
                new Panel
                {
                    Id = 3,
                    Title = "Recycling Equipment",
                    Description = "Recycling equipment description",
                    ImagePath = "/Images/RecyclingEquipment.jpg"
                },
                new Panel
                {
                    Id = 4,
                    Title = "Wire Shelvings",
                    Description = "Wire shelvings description",
                    ImagePath = "/Images/WireShelving.jpg"
                },
            };

            return panels;
        }
    }
}