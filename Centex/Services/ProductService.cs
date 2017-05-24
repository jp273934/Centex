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
        Wireshelvings
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
                    case ProductCategories.Wireshelvings:
                        return GetWireShelvings();
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
                "CMH specializes in various types of pallet racks like Cantilever racking, Clad Rack, Conventional, Drive in, Push back racks.",
                "Call CMH for an application specialist that can come to your facility, review your requirements, and provide you with the right rack for your needs."
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

        private Product GetWireShelvings()
        {
            var description = new List<string>
            {
                "Wire shelvings description"
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