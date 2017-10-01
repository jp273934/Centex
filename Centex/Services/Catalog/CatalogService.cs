using Centex.Models;
using Centex.Services.Catalog.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Centex.Services.Catalog
{
    public class CatalogService : ICatalogService
    {
        public CatalogItem GetCataLogItemById(int id)
        {
            return GetCatalogItems().Single(c => c.Id == id);
        }

        public IEnumerable<CatalogItem> GetCatalogItems()
        {
            return new List<CatalogItem>
            {
                new CatalogItem
                {
                    Id = 0,
                    Name = "Bins",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/bins/"
                },
                new CatalogItem
                {
                    Id = 1,
                    Name = "Boxes",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/boxes/"
                },
                  new CatalogItem
                {
                    Id = 3,
                    Name = "Cabinets",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/cabinets/"
                },
                 new CatalogItem
                {
                    Id = 4,
                    Name = "Carts",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/carts/"
                },
                   new CatalogItem
                {
                    Id = 5,
                    Name = "Casters",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/casters/"
                },
                       new CatalogItem
                {
                    Id = 6,
                    Name = "Chairs & Stools",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/chairs-and-stools/"
                },
                 new CatalogItem
                {
                    Id = 7,
                    Name = "Containers",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/containers/"
                },
                   new CatalogItem
                {
                    Id = 8,
                    Name = "Conveyors",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/conveyors/"
                },
                   new CatalogItem
                {
                    Id = 9,
                    Name = "Overhead Cranes",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/cranes/"
                },
                   new CatalogItem
                {
                    Id = 10,
                    Name = "Dock Equipment",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/dock-equipment/"
                },
                 new CatalogItem
                {
                    Id = 11,
                    Name = "Dollies",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/dollies/"
                },
                 new CatalogItem
                {
                    Id = 12,
                    Name = "Doors",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/doors/"
                },
                  new CatalogItem
                {
                    Id = 13,
                    Name = "Drums & Equipment",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/drums-and-equipment/"
                },
                   new CatalogItem
                {
                    Id = 15,
                    Name = "Dumper",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/dumper/"
                },
                   new CatalogItem
                {
                    Id = 16,
                    Name = "Ergonomic",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/ergonomic/"
                },
                   new CatalogItem
                {
                    Id = 17,
                    Name = "Forklift Equipment",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/forklift-equipment/"
                },
                   new CatalogItem
                {
                    Id = 18,
                    Name = "Guards",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/guards/"
                },
                      new CatalogItem
                {
                    Id = 19,
                    Name = "Hand Trucks",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/hand-trucks/"
                },
                   new CatalogItem
                {
                    Id = 20,
                    Name = "Hoists & Equipment",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/hoists-and-equipment/"
                },
                      new CatalogItem
                {
                    Id = 21,
                    Name = "Hoppers",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/hoppers/"
                },
                      new CatalogItem
                {
                    Id = 22,
                    Name = "Hose & Cord Reels",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/hose-and-cord-reels/"
                },

                new CatalogItem
                {
                    Id = 25,
                    Name = "Ladders",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/ladders/"
                },
                new CatalogItem
                {
                    Id = 26,
                    Name = "Lifts & Lifting Equipment",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/lifts-/-lifting-equipment/"
                },
                new CatalogItem
                {
                    Id = 27,
                    Name = "Lockers",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/lockers/"
                },
                new CatalogItem
                {
                    Id = 28,
                    Name = "Matting",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/matting/"
                },
                 new CatalogItem
                {
                    Id = 29,
                    Name = "Office Furniture",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/office-furniture/"
                },
                  new CatalogItem
                {
                    Id = 30,
                    Name = "Pallets & Equipment",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/pallets-and-equipment/"
                },
                 new CatalogItem
                {
                    Id = 31,
                    Name = "Partitions",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/partitions/"
                },
                  new CatalogItem
                {
                    Id = 32,
                    Name = "Platform",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/platform/"
                },
                 new CatalogItem
                {
                    Id = 33,
                    Name = "Racks",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/racks/"
                },
                  new CatalogItem
                {
                    Id = 34,
                    Name = "Reels",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/reels/"
                },
                 new CatalogItem
                {
                    Id = 35,
                    Name = "Safety Equipment",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/safety-equipment/"
                },
                  new CatalogItem
                {
                    Id = 36,
                    Name = "Scales",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/scales/"
                },
                 new CatalogItem
                {
                    Id = 37,
                    Name = "Security Equipment",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/security-equipment/"
                },
                  new CatalogItem
                {
                    Id = 38,
                    Name = "Shelving",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/shelving/"
                },
                 new CatalogItem
                {
                    Id = 39,
                    Name = "Shipping Supplies",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/shipping-supplies/"
                },
                  new CatalogItem
                {
                    Id = 40,
                    Name = "Strapping",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/strapping/"
                },
                 new CatalogItem
                {
                    Id = 41,
                    Name = "Structural Framing",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/structural-framing/"
                },
                 new CatalogItem
                {
                    Id = 42,
                    Name = "Tables",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/tables/"
                },
                 new CatalogItem
                {
                    Id = 43,
                    Name = "Tools",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/tools/"
                },
                 new CatalogItem
                {
                    Id = 44,
                    Name = "Trucks",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/trucks/"
                },
                new CatalogItem
                {
                    Id = 45,
                    Name = "Warehouse Equipment",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/warehouse-equipment/"
                },
                 new CatalogItem
                {
                    Id = 46,
                    Name = "Wire",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/wire/"
                },
                 new CatalogItem
                {
                    Id = 47,
                    Name = "Work Benches",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/work-benches/"
                },
                  new CatalogItem
                {
                    Id = 48,
                    Name = "Main",
                    Url = "http://centexmaterialhandling.theonlinecatalog.com/store/"
                }
            };
        }
    }
}