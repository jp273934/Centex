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
            };
        }

        public IEnumerable<Photo> GetPhotosByParentId(int id)
        {
            return GetPhotos().Where(p => p.ParentId == id);
        }
    }
}