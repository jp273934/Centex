using Centex.Models;
using Centex.Services.Products.Interfaces;
using System;
using System.Collections.Generic;

namespace Centex.Services.Products
{
    public enum ProductCategories
    {
        Crane,
        Palletrack,
        DockEquipment,
        Shelvings,
        Conveyors,
        Messanines
    }

    public class ProductService : IProductService
    {
        public Product GetProduct(ProductCategories category)
        {

            switch (category)
            {
                   case ProductCategories.Crane:
                       return GetCrane();
                   case ProductCategories.Palletrack:
                       return GetPalletRack();                   
                    case ProductCategories.Shelvings:
                        return GetShelvings();
                    case ProductCategories.DockEquipment:
                        return GetDockEquipment();
                    case ProductCategories.Conveyors:
                        return GetConveyors();
                    case ProductCategories.Messanines:
                        return GetMessanine();
                   default:
                       throw  new Exception("Category not found");
            }
        }

        private Product GetCrane()
        {
            var descriptions = new List<string>
            {
                "CMH designs, manufactures, installs and services complete overhead material handling systems and stocks hoists, trolleys, accessories, replacement parts and provides service for most major brands.",
                "We design, manufacture and install complete overhead material handling systems. Bridge cranes, Hoists, Chain Hoists, Wire Rope Hoists, Air Hoists, pendant controls, Radio controls. Top Running Single Girder, Under Running Single Girder, Top Running Double Girder, Under Running Double Girder, Gantry Crane, Single Leg Gantry Crane, Floor Mount Jib Crane, Wall Mount Jib Cranes, Free Standing Work Stations."
            };

            var listDescriptions = new List<string>
            {
                "Emergency Repair 24 hour availability",
                "Repair Most brands of hoists and cranes",
                "Crane & Hoist Repair Parts for all brands",
                "Service Scheduled preventative maintenance programs",
                "Load Testing Certified proof load testing of cranes & hoists",
                "OSHA Certifications Inspections and testing for OSHA compliance",
                "Modernization, Modification, and upgrades to your existing crane systems",
                "Below the Hook Slings, spreader bars, lifting attachments",
                "Ergonomic Systems Light capacity handling systems for assembly, warehouse and distribution handling",
                "Turnkey Crane Systems "
            };

            var product = new Product
            {
                Title = "Cranes",
                ImagePath = "/Images/bridgecrane.jpg",
                Descriptions = descriptions,
                ListDescriptions = listDescriptions
            };

            return product;
        }

        private Product GetPalletRack()
        {
            var description = new List<string>
            {
                "Pallet Racking is a storage system that increases the capacity of your existing warehouse, improves the overall workflow and efficiency, and leads to a more organized shop, factory, warehouse, distribution or logistics center.",
                "CMH specializes in warehouse pallet racking systems and warehouse shelving. Our Selective Pallet Racks, Structural Pallet Racks, Cantilever Racks, Drive-In Pallet Racks, Push-Back Racks, Carton Flow Racks, Pallet Flow Racks. Each of these racking systems serve a similar purpose, but vary in functionality and application. Depending on available space in your facility and style of inventory management, you will find the perfect warehouse racking for your facility here at Centex Material Handling."
            };

            var product = new Product
            {
                Title = "Pallet Racks",
                ImagePath = "/Images/Pallet.jpg",
                Descriptions = description
            };

            return product;
        }

        private Product GetDockEquipment()
        {
            var description = new List<string>
            {
                "Centex Material Handling offers Access Ramps, Dock Boards, Dock Plates, Dock Levelers, and Wheel Risers to make your loading and unloading procedures a breeze! Consult our experts on what dock equipment would be ideal for your warehouse loading docks, and take the first step to streamlining your company’s shipping and receiving processes."
            };

            var product = new Product
            {
                Title = "Loading Dock Equipment",
                ImagePath = "/Images/Main_Desc.png",
                Descriptions = description
            };

            return product;
        }

        private Product GetShelvings()
        {
            var description = new List<string>
            {
                "CMH offers a variety of warehouse shelving solutions including boltless shelving, archive shelving, bulk rack shelving, and chrome wire shelving. Boltless and archive shelving are easy to install with little to no hardware required, and can be easily customized to fit your facility and needs. Chrome wire shelving is perfect for organization while maintaining air circulation and light. These shelves are also very easy to assemble, easy to expand as your needs grow, and help keep your inventory and items fully visible. Bulk racks are ideal for multi-level storage of hardware, tools, and heavy duty items. Bulk racking is available in various configurations, and come standard with particle board decking with the optional upgrade to wire mesh decking."
            };

            var product = new Product
            {
                Title = "Shelvings",
                ImagePath = "/Images/WireShelving.jpg",
                Descriptions = description
            };

            return product;
        }

        private Product GetConveyors()
        {
            var description = new List<string>
            {
                "A conveyor system is a common piece of mechanical handling equipment that moves materials from one location to another. Conveyors are especially useful in applications involving the transportation of heavy or bulky materials. Conveyor systems allow quick and efficient transportation for a wide variety of materials, which make them very popular in the material handling and packaging industries. Many kinds of conveying systems are available, and are used according to the various needs of different industries."
            };

            var product = new Product
            {
                Title = "Conveyors",
                Descriptions = description
            };

            return product;
        }

        private Product GetMessanine()
        {
            var description = new List<string>
            {
                "Warehouse mezzanines and catwalks allow you to greatly increase the utilization of your square footage. Increase space efficiency and organization of your facility with a catwalk or mezzanine platform. Warehouse Mezzanines efficiently use the height of a facility, while doubling or even tripling the surface area. Mezzanines can be the most economical way to increase warehouse space without having to expand or relocate from Southern California. There are many important factors to consider when designing a mezzanine, including access-ways, work systems, products, and handling methods in order to plan accurately. Mezzanines may be completely disassembled; the parts re-used; and the structure, dimensions, and location easily modified."
            };

            var product = new Product
            {
                Title = "Warehouse Messanines",
                Descriptions = description
            };

            return product;
        }
    }
}