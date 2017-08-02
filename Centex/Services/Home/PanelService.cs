using Centex.Models;
using Centex.Services.Home.Interfaces;
using System.Collections.Generic;

namespace Centex.Services.Home
{
    public class PanelService : IPanelService
    {
        public IEnumerable<Panel> GetPanels()
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
                    Title = "Pallet Rack",
                    Description = "CMH represents the top crane manufactures in the world. Whether you need a Bridge Cranes (1-125 tons) or Workstation Cranes (150-4000lbs), CMH can supply you with the right crane for your application",
                    ImagePath = "/Images/Logos/Pallet Rack Pic.jpg"
                },
                new Panel
                {
                    Id = 2,
                    Title = "Loading Dock Equipment",
                    Description = "CMH supplies and installs a full range of dock equipment. Whether your company requires simple dock bumpers and accessories or a complete in-pit leveler and truck restraint, count on CMH to help you get the right equipment for your needs.",
                    ImagePath = "/Images/Logos/PioneerLeveler.jpg"                },
                new Panel
                {
                    Id = 3,
                    Title = "Shelving",
                    Description = "Recycling equipment description",
                    ImagePath = "/Images/Logos/QuantunShelving.jpg"                },
                new Panel
                {
                    Id = 4,
                    Title = "Conveyor",
                    Description = "Wire shelvings description",
                    ImagePath = "/Images/Logos/gravityconveyor.jpg"                },
                new Panel
                {
                    Id = 5,
                    Title = "Mezzanine",
                    ImagePath = "/Images/Logos/Mezzanie .jpeg"
                }
            };

            return panels;
        }
    }
}