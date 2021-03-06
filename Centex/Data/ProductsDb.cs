﻿using Centex.Models;
using Centex.Services;
using System.Collections.Generic;
using System.Linq;

namespace Centex.Data
{
    public class ProductsDb : IProductsDb
    {
        private readonly ISubDescripttionService _subDescripttionService;
        private readonly IProductDescriptionsService _productDescriptionsService;
        private readonly IProductImagesDb _productImagesDb;

        public ProductsDb(ISubDescripttionService subDescripttionService, IProductDescriptionsService productDescriptionsService, IProductImagesDb productImagesDb)
        {
            _subDescripttionService = subDescripttionService;
            _productDescriptionsService = productDescriptionsService;
            _productImagesDb = productImagesDb;
        }

        private IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 0, CatalogId = 1, Title = "Pallet Racks",  Descriptions = new Descriptions
                    {
                        MainDescriptions = _productDescriptionsService.GetDescriptionsById(0),
                        SubDescriptions = _subDescripttionService.GetSubDescriptionsByParentId(0),                       
                    },
                    Photos = _productImagesDb.GetPhotosByParentId(0),
                    ModalIds = new List<string> {"CantileverModal", "CladRackModal", "ConventionalModal", "DriveInModal", "PushBackModal"}
                },
                new Product
                {
                    Id = 1, Title = "Overhead Cranes", Descriptions = new Descriptions
                    {
                        MainDescriptions = _productDescriptionsService.GetDescriptionsById(1),
                        SubDescriptions = _subDescripttionService.GetSubDescriptionsByParentId(1),                       
                    },
                    Photos = _productImagesDb.GetPhotosByParentId(1),
                    ModalIds = new List<string> { "SingleGirderBridgeCraneModal", "DoubleGirderBridgeCraneModal", "UnderRunningBridgeCraneModal", "TopRunningBridgeCraneModal", "GantryCraneModal", "JibcraneModal", "FreestandingWorkstationCraneModal", "CeilingMountedWorkstationCraneModal" }
                },
                new Product
                {
                    Id = 2, Title = "Loading Docking Equipment", Descriptions = new Descriptions
                    {
                       MainDescriptions = _productDescriptionsService.GetDescriptionsById(2),
                       SubDescriptions = _subDescripttionService.GetSubDescriptionsByParentId(2)
                    },
                    Photos = _productImagesDb.GetPhotosByParentId(2),
                    ModalIds = new List<string> {"firstModal", "secondModal", "thirdModal", "fourthModal", "fifthModal" }
                },
                new Product
                {
                    Id = 3, Title = "Shelving", Descriptions = new Descriptions
                    {
                       MainDescriptions = _productDescriptionsService.GetDescriptionsById(3),
                       SubDescriptions = _subDescripttionService.GetSubDescriptionsByParentId(3)
                    },
                    Photos = _productImagesDb.GetPhotosByParentId(3),
                    ModalIds = new List<string> {"ArchiveShelvingModal", "AutomotiveShelvingModal", "BoltlessPBShelvingModal", "ClipShelvingModal", "WidespanShelvingModal", "WireShelvingModal" }
                },
                new Product
                {
                    Id = 4, Title = "Conveyors", Descriptions = new Descriptions
                    {
                       MainDescriptions = _productDescriptionsService.GetDescriptionsById(4),
                       SubDescriptions = _subDescripttionService.GetSubDescriptionsByParentId(4)
                    },
                    Photos = _productImagesDb.GetPhotosByParentId(4),
                    ModalIds = new List<string> {"firstModal", "secondModal", "thirdModal", "fourthModal", "fifthModal", "sixthModal", "seventhModal", "eightModal", "ninthModal" }
                },
                new Product
                {
                    Id = 5, Title = "Warehouse Mezzanines", Descriptions = new Descriptions
                    {
                       MainDescriptions = _productDescriptionsService.GetDescriptionsById(5),
                       SubDescriptions = _subDescripttionService.GetSubDescriptionsByParentId(5)
                    },
                    Photos = _productImagesDb.GetPhotosByParentId(5),
                    ModalIds = new List<string> {"firstModal", "secondModal", "thirdModal", "fourthModal", "fifthModal", "sixthModal", "seventhModal", "eightModal", "ninthModal" }
                },
                new Product
                {
                    Id = 6, Title = "Fall Protection Systems", Descriptions = new Descriptions
                    {
                        MainDescriptions = _productDescriptionsService.GetDescriptionsById(6),
                        SubDescriptions = _subDescripttionService.GetSubDescriptionsByParentId(6)
                    },
                    Photos = _productImagesDb.GetPhotosByParentId(6),
                    ModalIds = new List<string>{ "firstModal", "secondModal", "thirdModal", "fourthModal", "fifthModal", "sixthModal"}
                },
                new Product
                {
                    Id = 7, Title = "DEMAG DCS – Pro", Descriptions = new Descriptions
                    {
                        MainDescriptions = _productDescriptionsService.GetDescriptionsById(7),
                        SubDescriptions = new List<SubDescriptions>()
                        
                    }
                },
                new Product
                {
                    Id = 8, Title = "DEMAG DCM-Pro Manulift", Descriptions = new Descriptions
                    {
                        MainDescriptions = _productDescriptionsService.GetDescriptionsById(8),
                        SubDescriptions = new List<SubDescriptions>()
                    }
                },
                new Product
                {
                    Id = 9, Title = "GORBEL G-force", Descriptions = new Descriptions
                    {
                        MainDescriptions = _productDescriptionsService.GetDescriptionsById(9),
                        SubDescriptions = new List<SubDescriptions>(9)
                    }
                }
            };
        }

        public Product GetProductById(int id)
        {
            return GetProducts().First(p => p.Id == id);
        }
    }
}