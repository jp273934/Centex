using System.Collections.Generic;
using System.Linq;

namespace Centex.Models
{
    public class ProductDescriptionsService : IProductDescriptionsService
    {
        private IEnumerable<Descriptions> GetDescriptions()
        {
            return new List<Descriptions>
            {
                new Descriptions
                {
                    Id = 0, 
                    MainDescriptions = new List<string>
                    {
                         "Pallet Racking is a storage system that increases the capacity of your existing warehouse, improves the overall workflow and efficiency, and leads to a more organized shop, factory, warehouse, distribution or logistics center.",
                "CMH specializes in warehouse pallet racking systems and warehouse shelving. Our Selective Pallet Racks, Structural Pallet Racks, Cantilever Racks, Drive-In Pallet Racks, Push-Back Racks, Carton Flow Racks, Pallet Flow Racks. Each of these racking systems serve a similar purpose, but vary in functionality and application. Depending on available space in your facility and style of inventory management, you will find the perfect warehouse racking for your facility here at Centex Material Handling."
                    }
                },
                new Descriptions
                {
                    Id = 1,
                    MainDescriptions = new List<string>
                    {
                        "CMH designs, manufactures, installs and services complete overhead material handling systems and stocks hoists, trolleys, accessories, replacement parts and provides service for most major brands.",
                "We design, manufacture and install complete overhead material handling systems. Bridge cranes, Hoists, Chain Hoists, Wire Rope Hoists, Air Hoists, pendant controls, Radio controls. Top Running Single Girder, Under Running Single Girder, Top Running Double Girder, Under Running Double Girder, Gantry Crane, Single Leg Gantry Crane, Floor Mount Jib Crane, Wall Mount Jib Cranes, Free Standing Work Stations."
                    }
                },
                new Descriptions
                {
                    Id = 2,
                    MainDescriptions = new List<string>
                    {
                             "CMH designs, manufactures, installs and services complete overhead material handling systems and stocks hoists, trolleys, accessories, replacement parts and provides service for most major brands.",
                "We design, manufacture and install complete overhead material handling systems. Bridge cranes, Hoists, Chain Hoists, Wire Rope Hoists, Air Hoists, pendant controls, Radio controls. Top Running Single Girder, Under Running Single Girder, Top Running Double Girder, Under Running Double Girder, Gantry Crane, Single Leg Gantry Crane, Floor Mount Jib Crane, Wall Mount Jib Cranes, Free Standing Work Stations."
                    }
                },
                new Descriptions
                {
                    Id = 3,
                    MainDescriptions = new List<string>
                    {
                         "CMH offers a variety of warehouse shelving solutions including boltless shelving, archive shelving, bulk rack shelving, and chrome wire shelving. Boltless and archive shelving are easy to install with little to no hardware required, and can be easily customized to fit your facility and needs. Chrome wire shelving is perfect for organization while maintaining air circulation and light. These shelves are also very easy to assemble, easy to expand as your needs grow, and help keep your inventory and items fully visible. Bulk racks are ideal for multi-level storage of hardware, tools, and heavy duty items. Bulk racking is available in various configurations, and come standard with particle board decking with the optional upgrade to wire mesh decking."
                    }
                },
                new Descriptions
                {
                    Id = 4,
                    MainDescriptions = new List<string>
                    {
                        "A conveyor system is a common piece of mechanical handling equipment that moves materials from one location to another. Conveyors are especially useful in applications involving the transportation of heavy or bulky materials. Conveyor systems allow quick and efficient transportation for a wide variety of materials, which make them very popular in the material handling and packaging industries. Many kinds of conveying systems are available, and are used according to the various needs of different industries."
                    }
                },
                new Descriptions
                {
                    Id = 5,
                    MainDescriptions = new List<string>
                    {
                         "Warehouse mezzanines and catwalks allow you to greatly increase the utilization of your square footage. Increase space efficiency and organization of your facility with a catwalk or mezzanine platform. Warehouse Mezzanines efficiently use the height of a facility, while doubling or even tripling the surface area. Mezzanines can be the most economical way to increase warehouse space without having to expand or relocate from Southern California. There are many important factors to consider when designing a mezzanine, including access-ways, work systems, products, and handling methods in order to plan accurately. Mezzanines may be completely disassembled; the parts re-used; and the structure, dimensions, and location easily modified."
                    }
                }
            };
        }

        public IEnumerable<string> GetDescriptionsById(int id)
        {
            return GetDescriptions().First(d => d.Id == id).MainDescriptions;
        }
    }
}