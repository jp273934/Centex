using Centex.Models;
using Centex.Services.ServiceObjects;
using Centex.Services.ServiceObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Centex.Data
{
    public class ServicesDb : IServicesDb
    {
        private const string RootPath = "/Images/Services/";

        private IEnumerable<ServiceModel> GetServices()
        {
            const string loadTestPath = "LoadTest/";
            const string modsPath = "Mods/";

            return new List<ServiceModel>
            {
                new ServiceModel
                {
                    Id = 0,
                    Title = "Preventative Maintenance",
                    Descriptions = new List<ServiceDescription>
                    {
                        new ServiceDescription
                        {
                            Description = "CMH provides preventative maintenance services for various material handling equipment including overhead cranes and conveyors."
                        },
                        new ServiceDescription
                        {
                            Description = "CMH's purpose is to help our customers avoid or mitigate the consequences of equipment failure. CMH preserverves and restores your equipment by identifying and replacing worn components before they fail. We use extensive step-by-step check lists specific to your equipments OEM."
                        }
                    }
                },
                new ServiceModel
                {
                    Id = 1,
                    Title = "Load Test",
                    Images = new List<string>{ RootPath + loadTestPath + "20160916_121359.jpg", RootPath + loadTestPath + "20170526_185033.jpg", RootPath + loadTestPath + "20170824_155911.jpg", RootPath + loadTestPath + "Jib crane load test overhead pic.jpg", RootPath + loadTestPath + "20160806_194242.jpg", RootPath + loadTestPath + "1-100 tons 270x360.bmp", RootPath + loadTestPath + "5 ton conventional crane system demag.jpg"},
                    Descriptions = new List<ServiceDescription>
                    {
                        new ServiceDescription
                        {
                            Description = "CMH provides certified load tests for various material handling equipment. Whether you have an overhead crane, hoist, lift or specialty material handling equipment, CMH can test its capacity. Overhead cranes must be weight tested after initial installation or when a crane is altered (as it affects a load bearing component)."
                        },
                        new ServiceDescription
                        {
                            Description = "Call CMH for all your OSHA and ANSI load test requirements."
                        }
                    }
                },
                new ServiceModel
                {
                    Id = 2,
                    Title = "Inspections and Repairs",
                    Descriptions = new List<ServiceDescription>
                    {
                        new ServiceDescription
                        {
                            Description = "CMH provides inspection services for overhead cranes and conveyor systems. Our certified technicians take great care in meticulously inspecting all components and providing a detailed report of deficiencies found."
                        },
                        new ServiceDescription
                        {
                            Description = "CMH will review these inspections with our customers and provide the necessary repairs to keep your equipment safe and running at peak performance."
                        },
                        new ServiceDescription
                        {
                            Description = "CMH can supply and install all OEM components for conveyors and overhead crane systems. With all the various manufacturers, our customers take ease in knowing CMH is their one stop shop for overhead crane and conveyor repairs."
                        }
                    }
                },
                new ServiceModel
                {
                    Id = 3,
                    Title = "Relocation",
                    Descriptions = new List<ServiceDescription>
                    {
                        new ServiceDescription
                        {
                            Description = "CMH buys, sells & trades material handling and storage equipment."
                        },
                        new ServiceDescription
                        {
                            Description = "CMH provides new equipment installation services, as well as equipment relocation services."
                        },
                        new ServiceDescription
                        {
                            Description = "CMH will handle the complete process, including:",
                            Items = new List<string>{ "Relocation Planning ", "Layout", "Dismantling", "Logistics", "Storage", "Start-up", "Load testing" }
                        }
                    }
                },
                new ServiceModel
                {
                    Id = 4,
                    Title = "Modernization and Upgrades",
                    Images = new List<string>{ RootPath + modsPath + "20160102_125757.jpg", RootPath + modsPath + "20160807_185329.jpg", RootPath + modsPath + "20170728_113452.jpg", RootPath + modsPath + "20170728_114435.jpg", RootPath + modsPath + "DSC_0058.jpg", RootPath + modsPath + "DSC_0574.jpg", RootPath + modsPath + "Modifications & Upgrades Picture.jpg"},
                    Descriptions = new List<ServiceDescription>
                    {
                        new ServiceDescription
                        {
                            Description = "CMH provides modernization & Upgrades to Overhead Cranes, including:",
                            Items = new List<string>{ "Complete wiring testing & replacement", "Variable Frequency Drive (VFD) Upgrades", "Complete control panel replacement", "Capacity upgrades", "Span changes", "Wireless Radio Control systems", "Pendant control upgrades", "Runway power conduct upgrades/ add ground conductor", "Festoon track upgrades/replacement", "Crane decommissioning" }
                        },
                        new ServiceDescription
                        {
                            Description = "Count on CMH for complete crane modernization. We give old cranes new life!"
                        }
                    }
                }
            };
        }

        public ServiceModel GetServiceById(int id)
        {
            return GetServices().First(s => s.Id == id);
        }
    }
}