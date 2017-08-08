﻿using Centex.Models;
using System.Collections.Generic;
using System.Linq;

namespace Centex.Data
{
    public class ProductImagesDb : IProductImagesDb
    {
        private const string RootPath = "/Images/Products/";

        private IEnumerable<Photo> GetPhotos()
        {
            const string cranesPath = "Cranes/";
            const string palletRacksPath = "PalletRacks/";
            const string shelvingsPath = "Shelvings/";
            const string converyorPath = "Conveyors/";
            const string dockPath = "DockEquipment/";

            return new List<Photo>
            {
                new Photo
                {
                    ParentId = 0,
                    FilePath = RootPath + palletRacksPath + "1_thumb.jpg",
                    ImageDescription = "Image of cantilever racking"
                },
                new Photo
                {
                    ParentId = 0,
                    FilePath = RootPath + palletRacksPath + "2_thumb.jpg",
                    ImageDescription = "Image of clad rack warehouses pallet racks"
                },
                new Photo
                {
                    ParentId = 0,
                    FilePath = RootPath + palletRacksPath + "3_thumb.jpg",
                    ImageDescription = "Image of conventional pallet rack"
                },
                new Photo
                {
                    ParentId = 0,
                    FilePath = RootPath + palletRacksPath + "4_thumb.jpg",
                    ImageDescription = "Image of drive in pallet rack"
                },
                new Photo
                {
                    ParentId = 0,
                    FilePath = RootPath + palletRacksPath + "5_thumb.jpg",
                    ImageDescription = "Image of push back pallet rack",
                },
                new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "SingleGirder.png",
                    ImageDescription = "Image of single girder crane"
                },
                new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "DoubleGirder.jpg",
                    ImageDescription = "Image of double girder crane"
                },
                new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "UnderRunningBridge.png",
                    ImageDescription = "Image of under running bridge crane"
                },
                new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "TopRunningBridge.jpg",
                    ImageDescription = "Image of top running bridge crane"
                },
                new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "Gantry.jpg",
                    ImageDescription = "Image of gantry crane"
                },
                 new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "Jib.png",
                    ImageDescription = "Image of jib crane"
                },
                   new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "Freestanding.png",
                    ImageDescription = "Image of freestanding crane"
                },
                      new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "CeilingMounted.png",
                    ImageDescription = "Image of ceiling mounted crane"
                },
                new Photo
                {
                    ParentId = 2,
                    FilePath = RootPath + dockPath + "DockEquipment1.jpg",
                    ImageDescription = "Image of dock lever equipment"
                },
                new Photo
                {
                    ParentId = 2,
                    FilePath = RootPath + dockPath + "DockEquipment2.jpg",
                    ImageDescription = "Image of dock lever equipment"
                },
                 new Photo
                {
                    ParentId = 2,
                    FilePath = RootPath + dockPath + "DockEquipment3.jpg",
                    ImageDescription = "Image of dock lever equipment"
                },
                 new Photo
                {
                    ParentId = 2,
                    FilePath = RootPath + dockPath + "DockEquipment4.jpg",
                    ImageDescription = "Image of dock lever equipment"
                },
                new Photo
                {
                    ParentId = 2,
                    FilePath = RootPath + dockPath + "DockEquipment5.jpg",
                    ImageDescription = "Image of dock lever equipment"
                },
                  new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Archive Shelving.jpg",
                    ImageDescription = "Image of archive shelving"
                },
                 new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Automotive Shelving.jpg",
                    ImageDescription = "Image of automotive shelving"
                },
                  new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Boltless PB Shelving.jpg",
                    ImageDescription = "Image of boltless shelving"
                },
                new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Clip Shelving.jpg",
                    ImageDescription = "Image of clip shelving"
                },
                new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Hallowell-Shelving.png",
                    ImageDescription = "Image of hallowell shelving"
                },
                new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Rivet-Shelving.jpg",
                    ImageDescription = "Image of rivet shelving"
                },
                new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Tire Storage Shelving.jpg",
                    ImageDescription = "Image of tire storage shelving"
                },
                new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Widespan shelving.jpg",
                    ImageDescription = "Image of widespan shelving"
                },
                 new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Wire Shelving.jpg",
                    ImageDescription = "Image of wire shelving"
                },
                  new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Ball Transfer Table.jpg",
                    ImageDescription = "Image of ball transfer table conveyor"
                },
                 new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Flexible Gravity Conveyor.jpg",
                    ImageDescription = "Image of flexible gravity conveyor"
                },
                 new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Gravity Conveyor (1).jpg",
                    ImageDescription = "Image of gravity conveyor"
                },
                new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Live Roller Conveyor.jpg",
                    ImageDescription = "Image of live roller conveyor"
                },
                new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Omni Directional Conveyor.jpg",
                    ImageDescription = "Image of omni directional conveyor"
                },
                new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Pallet Conveyor.jpg",
                    ImageDescription = "Image of pallet conveyor"
                },
                new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Roller Bed Conveyor.jpg",
                    ImageDescription = "Image of roller bed conveyor"
                },
                new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Slider Bed Conveyor.jpg",
                    ImageDescription = "Image of slider"
                },
                new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Wire Mesh Belt Conveyor.png",
                    ImageDescription = "Image of wire mesh belt conveyor"
                },
            };
        }

        public IEnumerable<Photo> GetPhotosByParentId(int id)
        {
            return GetPhotos().Where(p => p.ParentId == id);
        }
    }
}