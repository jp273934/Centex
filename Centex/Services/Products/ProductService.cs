using Centex.Data;
using Centex.Models;
using Centex.Services.Products.Interfaces;
using Centex.ViewModels;
using System;
using System.Collections.Generic;

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
          
            var product = new ProductViewModel
            {
                Title = "Cranes",
                ProductType = Categories.ItemType.Product,
                Product = _productsDb.GetProductById(1),
                ListDescriptions = listDescriptions,
                CatalogId = 9
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
            var product = new ProductViewModel
            {
                Title = "Loading Dock Equipment",
                ProductType = Categories.ItemType.Product,
                Product = _productsDb.GetProductById(2),
                CatalogId = 10
            };

            return product;
        }

        private ProductViewModel GetShelvings()
        {           
            var product = new ProductViewModel
            {
                Title = "Shelvings",
                ProductType = Categories.ItemType.Product,
                Product = _productsDb.GetProductById(3),
                CatalogId = 38
            };

            return product;
        }

        private ProductViewModel GetConveyors()
        {
           

            var product = new ProductViewModel
            {
                Title = "Conveyors",
                ProductType = Categories.ItemType.Product,
                Product = _productsDb.GetProductById(4),
                CatalogId = 8
            };

            return product;
        }

        private ProductViewModel GetMessanine()
        {           
            var product = new ProductViewModel
            {
                Title = "Warehouse Mezzanines",
                ProductType = Categories.ItemType.Product,
                Product = _productsDb.GetProductById(5),
                CatalogId = 45
            };

            return product;
        }
    }
}