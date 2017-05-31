using Centex.Models;
using System;
using System.Collections.Generic;

namespace Centex.Services
{
    public enum ProductCategories
    {
        Bridgecrane,
        Palletrack,
        Docklever,
        Recyling,
        Shelvings
    }

    public class ProductService
    {
        public Product GetProduct(ProductCategories category)
        {

            switch (category)
            {
                   case ProductCategories.Bridgecrane:
                       return GetBridgeCrane();
                   case ProductCategories.Palletrack:
                       return GetPalletRack();
                    case ProductCategories.Docklever:
                        return GetDockLever();
                    case ProductCategories.Recyling:
                        return GetRecyclingEqupment();
                    case ProductCategories.Shelvings:
                        return GetShelvings();
                   default:
                       throw  new Exception("Category not found");
            }
        }

        private Product GetBridgeCrane()
        {
            var descriptions = new List<string>
            {
                "CMH represents the tope crane manufacturers in the world. Whether you need a Bridge Cranes (1-125 tons) or Workstation Cranes (150-4000lbs), CMH can supply you with the right crane for your application.",
                "CMH provides complete crane services including engineering, weight test certification, annual crane inspections, and repairs.",
                "Call CMH for an application specialist that can come to your facility, review your requirements, and provide you with the right crane for your needs"
            };

            var product = new Product
            {
                Title = "Bridge Cranes",
                ImagePath = "/Images/bridgecrane.jpg",
                Descriptions = descriptions
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
                Title = "Pallet Rack",
                ImagePath = "/Images/Pallet.jpg",
                Descriptions = description
            };

            return product;
        }

        private Product GetDockLever()
        {
            var description = new List<string>
            {
                "CMH supplies and installs a full range of dock equipment. Whether your company requires simple dock bumpers and accessories or a complete in-pit leveler and truck restraint, count on CMH to help you get the right equipment for your needs."
            };

            var product = new Product
            {
                Title = "Dock Levers",
                ImagePath = "/Images/Main_Desc.png",
                Descriptions = description
            };

            return product;
        }

        private Product GetRecyclingEqupment()
        {
            var description = new List<string>
            {
                "Recycling equipment description"
            };

            var product = new Product
            {
                Title = "Recycling Equipment",
                ImagePath = "/Images/RecyclingEquipment.jpg",
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
                Title = "Recycling Equipment",
                ImagePath = "/Images/WireShelving.jpg",
                Descriptions = description
            };

            return product;
        }
    }
}