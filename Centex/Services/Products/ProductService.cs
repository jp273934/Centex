using Centex.Data;
using Centex.Models;
using Centex.Services.Products.Interfaces;
using Centex.ViewModels;
using System;

namespace Centex.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductsDb _productsDb;

        public ProductService(IProductsDb productsDb)
        {
            _productsDb = productsDb;
        }

        public ProductViewModel GetProduct(Categories.ProductCategories category)
        {

            switch (category)
            {
                   case Categories.ProductCategories.Crane:
                       return GetCrane();
                   case Categories.ProductCategories.Palletrack:
                    return GetPalletRack();
                case Categories.ProductCategories.Shelvings:
                        return GetShelvings();
                    case Categories.ProductCategories.DockEquipment:
                        return GetDockEquipment();
                    case Categories.ProductCategories.Conveyors:
                        return GetConveyors();
                    case Categories.ProductCategories.Messanines:
                        return GetMessanine();
                   default:
                       throw  new Exception("Category not found");
            }
        }

        private ProductViewModel GetCrane()
        {
            //var descriptions = new List<string>
            //{
            //    "CMH designs, manufactures, installs and services complete overhead material handling systems and stocks hoists, trolleys, accessories, replacement parts and provides service for most major brands.",
            //    "We design, manufacture and install complete overhead material handling systems. Bridge cranes, Hoists, Chain Hoists, Wire Rope Hoists, Air Hoists, pendant controls, Radio controls. Top Running Single Girder, Under Running Single Girder, Top Running Double Girder, Under Running Double Girder, Gantry Crane, Single Leg Gantry Crane, Floor Mount Jib Crane, Wall Mount Jib Cranes, Free Standing Work Stations."
            //};

            //var listDescriptions = new List<string>
            //{
            //    "Emergency Repair 24 hour availability",
            //    "Repair Most brands of hoists and cranes",
            //    "Crane & Hoist Repair Parts for all brands",
            //    "Service Scheduled preventative maintenance programs",
            //    "Load Testing Certified proof load testing of cranes & hoists",
            //    "OSHA Certifications Inspections and testing for OSHA compliance",
            //    "Modernization, Modification, and upgrades to your existing crane systems",
            //    "Below the Hook Slings, spreader bars, lifting attachments",
            //    "Ergonomic Systems Light capacity handling systems for assembly, warehouse and distribution handling",
            //    "Turnkey Crane Systems "
            //};

            //var product = new Product
            //{
            //    Title = "Cranes",
            //    ImagePath = "/Images/bridgecrane.jpg",
            //    Descriptions = descriptions,
            //    ListDescriptions = listDescriptions,
            //    CatalogId = 9
            //};

            var product = new ProductViewModel
            {
                Title = "Cranes",
                ProductType = Categories.ItemType.Product,
                Product = _productsDb.GetProductById(1)
            };

            return product;
        }

        private ProductViewModel GetPalletRack()
        {           

            var product = new ProductViewModel
            {
                Title = "Pallet Racks",
                ProductType = Categories.ItemType.Product,
                Product = _productsDb.GetProductById(0)
            };

            return product;
        }

        private ProductViewModel GetDockEquipment()
        {
            //var description = new List<string>
            //{
            //    "Centex Material Handling offers Access Ramps, Dock Boards, Dock Plates, Dock Levelers, and Wheel Risers to make your loading and unloading procedures a breeze! Consult our experts on what dock equipment would be ideal for your warehouse loading docks, and take the first step to streamlining your company’s shipping and receiving processes."
            //};

            //var product = new Product
            //{
            //    Title = "Loading Dock Equipment",
            //    ImagePath = "/Images/Main_Desc.png",
            //    Descriptions = description,
            //    CatalogId = 10
            //};

            var product = new ProductViewModel
            {
                Title = "Loading Dock Equipment",
                ProductType = Categories.ItemType.Product,
                Product = _productsDb.GetProductById(2)
            };

            return product;
        }

        private ProductViewModel GetShelvings()
        {
            //var description = new List<string>
            //{
            //    "CMH offers a variety of warehouse shelving solutions including boltless shelving, archive shelving, bulk rack shelving, and chrome wire shelving. Boltless and archive shelving are easy to install with little to no hardware required, and can be easily customized to fit your facility and needs. Chrome wire shelving is perfect for organization while maintaining air circulation and light. These shelves are also very easy to assemble, easy to expand as your needs grow, and help keep your inventory and items fully visible. Bulk racks are ideal for multi-level storage of hardware, tools, and heavy duty items. Bulk racking is available in various configurations, and come standard with particle board decking with the optional upgrade to wire mesh decking."
            //};

            //var product = new Product
            //{
            //    Title = "Shelvings",
            //    ImagePath = "/Images/WireShelving.jpg",
            //    Descriptions = description,
            //    CatalogId = 38
            //};

            var product = new ProductViewModel
            {
                Title = "Shelvings",
                ProductType = Categories.ItemType.Product,
                Product = _productsDb.GetProductById(3)
            };

            return product;
        }

        private ProductViewModel GetConveyors()
        {
           

            var product = new ProductViewModel
            {
                Title = "Conveyors",
                ProductType = Categories.ItemType.Product,
                Product = _productsDb.GetProductById(4)
                //Descriptions = description,
                //CatalogId = 8
            };

            return product;
        }

        private ProductViewModel GetMessanine()
        {
            //var description = new List<string>
            //{
            //    "Warehouse mezzanines and catwalks allow you to greatly increase the utilization of your square footage. Increase space efficiency and organization of your facility with a catwalk or mezzanine platform. Warehouse Mezzanines efficiently use the height of a facility, while doubling or even tripling the surface area. Mezzanines can be the most economical way to increase warehouse space without having to expand or relocate from Southern California. There are many important factors to consider when designing a mezzanine, including access-ways, work systems, products, and handling methods in order to plan accurately. Mezzanines may be completely disassembled; the parts re-used; and the structure, dimensions, and location easily modified."
            //};

            //var product = new Product
            //{
            //    Title = "Warehouse Mezzanines",
            //    Descriptions = description,
            //    CatalogId = 45
            //};

            var product = new ProductViewModel
            {
                Title = "Warehouse Mezzanines",
                ProductType = Categories.ItemType.Product,
                Product = _productsDb.GetProductById(5)
            };

            return product;
        }
    }
}