using Centex.Models;
using System;
using System.Collections.Generic;

namespace Centex.Services
{
    public enum ServiceCategories
    {
        Preventivemaintenance,
        Certifiedloadtest,
        Inspectionrepairs,
        Relocation,
        Modificationupgrades
    }

    public class Service
    {
        public ServiceModel GetModel(ServiceCategories category)
        {
            switch (category)
            {
                case ServiceCategories.Preventivemaintenance:
                    return GetPreventiveMaintenance();
                case ServiceCategories.Certifiedloadtest:
                    return GetCertifiedLoadTest();
                case ServiceCategories.Inspectionrepairs:
                    return GetInspecitionRepairs();
                case ServiceCategories.Relocation:
                    return GetRelocation();
                case ServiceCategories.Modificationupgrades:
                    return GetModificationUpgrades();
                default:
                    throw new ArgumentOutOfRangeException(nameof(category), category, null);
            }
        }

        private ServiceModel GetPreventiveMaintenance()
        {
            var descriptions = new List<string>
            {
                "CMH provides preventative maintenance services for various material handling equipment including overhead cranes and conveyors.",
                "CMH's purpose is to help our customers avoid or mitigate the consequences of equipment failure. CMH preserves and restores your equipment failure. CMH preserverves and restores your equipment by identifying and replacing worn components before they fail. We use extensive step-by-step check lists specific to your equipments OEM."
            };

            return new ServiceModel
            {
                ImagePath = "/Images/preventative.jpg",
                Title = "Preventative Maintenance",
                Descriptions = descriptions
            };
        }

        private ServiceModel GetCertifiedLoadTest()
        {
            var descriptions = new List<string>
            {
                "CMH provides certified load tests for various material handling equipment. Whether you have an overhead crane, hoist, lift or specialty material handling equipment, CMH can test its capacity. Overhead cranes must be weight tested after initial installation or when a crane is altered (as it affects a load bearing component).",
                "Call CMH for all your OSHA for all your OSHA and ANSI load test requirements."
            };

            return new ServiceModel
            {
                ImagePath = "/Images/loadtest.jpg",
                Title = "Certified Load Test",
                Descriptions = descriptions
            };
        }

        private ServiceModel GetInspecitionRepairs()
        {
            var descriptions = new List<string>
            {
                "CMH provides inspection services for overhead cranes and conveyor systems. Our certified technicians take great care in meticulously inspecting all components and providing a detailed report of deficiencies found.",
                "CMH will review these inspections with our customers and provide the necessary repairs to keep your equipment safe and running at peak performance.",
                "CMH can supply and install all OEM components for conveyors and overhead crane systems. With all the various manufacturers, our customers take ease in knowing CMH is their one stop shop for overhead crane and conveyor repairs."
            };

            return new ServiceModel
            {
                ImagePath = "/Images/preventative.jpg",
                Title = "Inspections and Repairs",
                Descriptions = descriptions
            };
        }

        private ServiceModel GetRelocation()
        {
            var descriptions = new List<string>
            {
                "Relocation description"               
            };

            return new ServiceModel
            {
                ImagePath = "/Images/tearout.jpg",
                Title = "Relocation",
                Descriptions = descriptions
            };
        }

        private ServiceModel GetModificationUpgrades()
        {
            var descriptions = new List<string>
            {
                "Modification and Upgrades description"
            };

            return new ServiceModel
            {
                ImagePath = "/Images/modification.jpg",
                Title = "Modification and Upgrades",
                Descriptions = descriptions
            };
        }
    }
}