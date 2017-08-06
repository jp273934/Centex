using Centex.Models;
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

            return new List<Photo>
            {
                new Photo
                {
                    ParentId = 0,
                    FilePath = RootPath + palletRacksPath + "1_thumb.jpg"
                },
                new Photo
                {
                    ParentId = 0,
                    FilePath = RootPath + palletRacksPath + "2_thumb.jpg"
                },
                new Photo
                {
                    ParentId = 0,
                    FilePath = RootPath + palletRacksPath + "3_thumb.jpg"
                },
                new Photo
                {
                    ParentId = 0,
                    FilePath = RootPath + palletRacksPath + "4_thumb.jpg"
                },
                new Photo
                {
                    ParentId = 0,
                    FilePath = RootPath + palletRacksPath + "5_thumb.jpg"
                },
                new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "SingleGirder.png"
                },
                new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "DoubleGirder.jpg"
                },
                new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "UnderRunningBridge.png"
                },
                new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "TopRunningBridge.jpg"
                },
                new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "Gantry.jpg"
                },
                 new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "Jib.png"
                },
                   new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "Freestanding.png"
                },
                      new Photo
                {
                    ParentId = 1,
                    FilePath = RootPath + cranesPath + "CeilingMounted.png"
                },
                  new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Archive Shelving.jpg"
                },
                 new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Automotive Shelving.jpg"
                },
                  new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Boltless PB Shelving.jpg"
                },
                new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Clip Shelving.jpg"
                },
                new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Hallowell-Shelving.png"
                },
                new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Rivet-Shelving.jpg"
                },
                new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Tire Storage Shelving.jpg"
                },
                new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Widespan shelving.jpg"
                },
                 new Photo
                {
                    ParentId = 3,
                    FilePath = RootPath + shelvingsPath + "Wire Shelving.jpg"
                },
                  new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Ball Transfer Table.jpg"
                },
                 new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Flexible Gravity Conveyor.jpg"
                },
                 new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Gravity Conveyor (1).jpg"
                },
                new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Live Roller Conveyor.jpg"
                },
                new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Omni Directional Conveyor.jpg"
                },
                new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Pallet Conveyor.jpg"
                },
                new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Roller Bed Conveyor.jpg"
                },
                new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Slider Bed Conveyor.jpg"
                },
                new Photo
                {
                    ParentId = 4,
                    FilePath = RootPath + converyorPath + "Wire Mesh Belt Conveyor.png"
                },
            };
        }

        public IEnumerable<Photo> GetPhotosByParentId(int id)
        {
            return GetPhotos().Where(p => p.ParentId == id);
        }
    }
}