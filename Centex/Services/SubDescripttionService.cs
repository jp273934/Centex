﻿using Centex.Models;
using System.Collections.Generic;
using System.Linq;

namespace Centex.Services
{
    public class SubDescripttionService : ISubDescripttionService
    {
        private IEnumerable<SubDescriptions> GetSubDescriptions()
        {
            return new List<SubDescriptions>
            {
               new SubDescriptions
               {
                   Title = "Cantilever Racking",
                   ParentId = 0,
                   Descriptions = new List<string> {"It is specifically designed to store long loads such as beams, profiles, pipes and timber. This rack enables loads to be handled by using lifting systems such as lift trucks, mobile cranes, stacker cranes, etc. These systems are chosen depending on the load to be stored (mainly weight and dimensions) or the height of the rack itself.", "The system consists of columns with a vertical beam and one or two horizontal beams at the base to provide stability. A series of arms are attached on which the load is placed. These columns are made of hot-rolled metal beams at variable heights enabling to be fitted. Moreover, its design allows the loads to be fitted on one side of the structure only, or on both sides." },    
                    ListDescriptions = new List<string>
                    {
                        "Easy to assemble. The parts are designed to allow the shelves to be assembled quickly and easily.",
                        "Structure of great simplicity, strength and excellent mobility."
                    }
               },
               new SubDescriptions
               {
                   Title = "Clad Rack Warehouses",
                   ParentId = 0,
                   Descriptions = new List<string>
                   {
                       "Major works of engineering in which the racking itself forms part of the construction of the building together with side and roof cladding.The ranking structure supports not only the actual goods and the different building elements but also the thrust of the handling devices and external elements: winds, heavy snowfalls, seismic movements, etc.", "The maximum height of clad-rack buildings is limited by local standards and by the reach height of stacker cranes or fork-lift trucks. This said, warehouses of more than 30m high can by built."
                   },
                   ListDescriptions = new List<string>
                   {
                       "Storage at high height, enables maximum use of available surface area without wastage of space.",
                       "Allows a wide range of goods to be stored.",
                       "Conventional or automated systems can be used."
                   }
               },
               new SubDescriptions
               {
                   Title = "Conventional Pallet Rack",
                   ParentId = 0,
                   Descriptions = new List<string>
                   {
                       "The most universal system for direct and single access to each pallet. The optimal solutions for those warehouses with palletized products and a wide variety of SKUs.", "The working aisle measurement between each rack and the rack height depends upon the characteristic of the forklift trucks or lifting devices, pallet size and the height of the warehouse itself.", "In order to store a greater number of pallets double-deep racks can be installed enabling one pallet to be stored in front of another on each side of the aisle."
                   },
                   ListDescriptions = new List<string>
                   {
                       "Total stock control: each storage space is taken up by a single pallet.",
                       "Maximum adaptability to any load type both in terms of weight and volume.",
                       "It can be combined with long span beams for manual selection of goods."
                   }
               },
               new SubDescriptions
               {
                   Title = "Drive In Pallet Rack",
                   ParentId = 0,
                   Descriptions = new List<string>
                   {
                       "This system is base on the storage by accumation principle, which enables the highest use of available space in terms of both area and height. Drive-in racking is designed for the storage of homogenous products. It accommodates a large number of pallets for each SKU.", "Two management systems are available: the drive-in system, with only one access aisle, and the drive-through system, with access to the load from both sides of the rack. The System is frequently use in cold stores (refrigeration and freezing) which require maximum use of space for the storage of producs in a controlled temperature."
                   },
                   ListDescriptions = new List<string>
                   {
                       "Maximum profitability of the available space (up to 85%).",
                       "Removal of aisles between the ranking",
                       "Rigorous control of entries and exits.",
                       "It allows as many SKU as loading lanes."
                   }
               },
               new SubDescriptions
               {
                   Title = "Push-Back Pallet Rack",
                   ParentId = 0,
                   Descriptions = new List<string>
                   {
                       "An accumulative storage system that allows up to four pallets deep to be stored per level. All of the pallets of each level, except the top one, are placed on a set of trolleys that are pushed along rolling rails." , "Push-back is ideal for storing medium-turnover products, with two or more pallets per SKU(using the Last In First Out(or LIFO system)."
                   },
                   ListDescriptions = new List<string>
                   {
                       "The best possible use is made of the space available.",
                       "Very little height space is waisted",
                       "Each level can be used to store different SKU"
                   }
               },
               new SubDescriptions
               {
                   Title = "Single Girder Bridge Crange",
                   ParentId = 1,
                   Descriptions = new List<string>
                   {
                       "This type of overhead crane configuration is made up of a single bridge girder, two end trucks, and a trolley hoist which runs along the bottom flange of the bridge girder between the end trucks."
                   }
               },
               new SubDescriptions
               {
                   Title = "Double Girder Bridge Crange",
                   ParentId = 1,
                   Descriptions = new List<string>
                   {
                       "A double girder overhead crane configuration is made up of two bridge girders, two end trucks, and a trolley hoist assembly. The trolley hoist travels on top of rails that are mounted to the top of the bridge girders."
                   }
               },
               new SubDescriptions
               {
                   Title = "Under Running Bridge Crane",
                   ParentId = 1,
                   Descriptions = new List<string>
                   {
                       "The bridge of an underhung crane is engineered to travel on the bottom flange of a runway beam. The roof structure of a building typically supports the runway beam in this type of configuration."
                   }
               },
               new SubDescriptions
               {
                   Title = "Top Running Bridge Crane",
                   ParentId = 1,
                   Descriptions = new List<string>
                   {
                       "The bridge of a top running crane is designed to travel on rails that are mounted onto the runway beams. The beams can be supported by either precisely engineered free-standing columns or by the existing columns of the building."
                   }
               },
               new SubDescriptions
               {
                   Title = "Gantry Crane",
                   ParentId = 1,
                   Descriptions = new List<string>
                   {
                       "A gantry crane can be designed with either a single or double girder bridge; however the main difference is that the gantry girders are attached to legs on both sides of the span. The end trucks are at the bottom of the legs allowing the crane to travel directly on the ground or on a rail system that can either be laid on top of the floor or embedded in the floor. This gantry design eliminates the need for a column or overhead runway system."
                   }
               },
               new SubDescriptions
               {
                   Title = "Jib crane",
                   ParentId = 1,
                   Descriptions = new List<string>
                   {
                       "A Jib Crane is another great solution that could fit your company’s specific needs. The jib design is made up of a boom (cantilever) and is mounted to a column. With this design, the trolley hoist assembly can move back and forth across the boom and it can be engineered to rotate in a full 360 degree circle."
                   }
               },
                new SubDescriptions
               {
                   Title = "Freestanding Workstation Crane",
                   ParentId = 1,
                   Descriptions = new List<string>
                   {
                       "Free Standing floor supported systems do not put stress on the building's overhead structure. Installation is usually straight forward, and these cranes are also easier to relocate in the future. Free Standing systems require a reinforced concrete floor of at least 6 inches."
                   },
                   ListDescriptions = new List<string>
                   {
                       "Capacities from 150 to 4000 lbs.",
                       "Rectangular Coverage with up to 34’ bridge and 124’ runway standard",
                       "Standard support distances of 20, 25, and 30 feet.",
                       "Easy to move and position loads",
                       "Modular design for greater flexibility",
                       "Doesn't require existing support structure"
                   }
               },
                 new SubDescriptions
               {
                   Title = "Ceiling Mounted Workstation Crane",
                   ParentId = 1,
                   Descriptions = new List<string>
                   {
                       "With Ceiling Mounted Systems, supporting steel does not interfere with the handling operation. Ceiling Mounted Systems require a building with an adequate overhead structure to hang the crane."
                   },
                   ListDescriptions = new List<string>
                   {
                       "Capacities from 150 to 4000 lbs. ",
                       "Rectangular Coverage with up to 34’ bridge and 124’ runway standard",
                       "Standard support distances of 20, 25, and 30 feet."
                   }
               },
                 new SubDescriptions
               {
                   ParentId = 2,
                   Descriptions = new List<string>
                   {
                       "Adjustable hydraulic dock levelers are a great option for many loading dock areas. These levelers are built for durability even under heavy traffic conditions. There are a number of different options available, check out the push button models that make hydraulic levelers simple."
                   },
                   Title = "Hydraulic Dock Levelers"
               },
                  new SubDescriptions
               {
                   ParentId = 2,
                   Descriptions = new List<string>
                   {
                       "A mechanical dock level has a simple chain operation. These levelers are ideal when you need a budget-friendly leveler that will provide years of great service. A mechanical leveler works under nearly any condition, even in hot or cold weather."
                   },
                   Title = "Mechanical Dock Levelers"
               },
                   new SubDescriptions
               {
                   ParentId = 2,
                   Descriptions = new List<string>
                   {
                       "This style of leveler is the industry standard in surface-mounted dock leveler. The up-front cost of these levelers is low, but you don’t sacrifice quality. One of the “Top-of Dock”, hydraulic or mechanical edge-of-dock levelers will last you for years and stand up to heavy use."
                   },
                   Title = "Edge of Dock Levelers"
               },
                    new SubDescriptions
               {
                   ParentId = 2,
                   Descriptions = new List<string>
                   {
                       "A foam dock seal with fixed head pad over side pads provides the tightest possible seal between interior & exterior environments for high volume traffic with consistent trailer widths & heights. This three sided seal is still the leading cost effective means to seal a dock door opening."
                   },
                   Title = "Dock Seal"
               },
                     new SubDescriptions
               {
                   ParentId = 2,
                   Descriptions = new List<string>
                   {
                       "Vehicle restraints and dock lock safety systems are a key component of efficent and safe modern loading docks. Vehicle restraints lock trailers into position at the loading dock. The vehicle restraint systems incorporate an intergrated system of signal lights, inside on the vehicle restraint control panel and outside on the facility wall to communicate loading and restraint status to the dock attendant as well as the truck driver."
                   },
                   Title = "Vehicle Restraint"
               },
                        new SubDescriptions
               {
                   ParentId = 3,
                   Title = "Archive Shelving",
                   Descriptions = new List<string>
                   {
                       "Designed for the hand-loading of intermediate weight bulky items, this versatile rack system can be used in hundreds of storage applications.",
                       "In addition to storing carton merchandise in shipping and receiving departments, it can also be used for display racking in furniture and department stores, for storage of medical and dietary supplies in hospitals and more."
                   }
               },
                  new SubDescriptions
               {
                   ParentId = 3,
                   Title = "Automotive Shelving",
                   Descriptions = new List<string>
                   {
                       "Automotive shelving provides a highly versatile system for efficiently storing automobile parts and accessories including tires."
                   }
               },
                   new SubDescriptions
               {
                   ParentId = 3,
                   Title = "Boltless PB Shelving",
                   Descriptions = new List<string>
                   {
                       "Boltless systems maximize existing square footage economically – all shelving can be disassembled with ease, transported, and recombined to create extra storage where needed. Installation costs are 30-40% lower than bolted shelving because rapid assembly requires much less time."
                   }
               },
                    new SubDescriptions
               {
                   ParentId = 3,
                   Title = "Clip Shelving",
                   Descriptions = new List<string>
                   {
                       "Clip Shelving is the universal answer, solving any basic storage problem with ease. Open design ensures easy stocking and retrieval. Compression clip provides bolt-free assembly; also makes shelf adjustments quick and easy. Sway braces on rear and sides provides ultimate stability. Ideal for bulky or packaged items. Shelves are adjustable in 1 1/2” increments."
                   }
               },
                                                         
                new SubDescriptions
               {
                   ParentId = 3,
                   Title = "Widespan Shelving",
                   Descriptions = new List<string>
                   {
                       "Wide Span Shelving is designed for the hand-loading of medium to heavy loads and is ideal for storing small quantities of a large variety of product types. Available with an assortment of accessories and components, Wide Span Shelving can be adapted to meet a variety of hand-stack storage requirements. It can even be paired with stairs and catwalks to create multiple levels of storage, maximizing the height of your warehouse."
                   }
               },
                new SubDescriptions
               {
                   ParentId = 3,
                   Title = "Wire Shelving",
                   Descriptions = new List<string>
                   {
                       "The ever popular chrome wire shelving system is perfect for any dry storage application. Chrome wire shelving is by far the most popular wire shelving style we offer due to its simple assembly without tools!",
                       "Wire shelving has become one of the most popular storage systems available to consumers and Industrial users alike. With storage capacities of 600-800 LBS per shelf, wire shelving can help organize any storage area."
                   }
               },
                     new SubDescriptions
                     {
                         ParentId = 4,
                         Title = "Ball Transfer Table",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                     new SubDescriptions
                     {
                         ParentId = 4,
                         Title = "Flexible Gravity Conveyor",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                     new SubDescriptions
                     {
                         ParentId = 4,
                         Title = "Gravity Conveyor",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                     new SubDescriptions
                     {
                         ParentId = 4,
                         Title = "Live Roller Conveyor",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                     new SubDescriptions
                     {
                         ParentId = 4,
                         Title = "Omni Directional Conveyor",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                     new SubDescriptions
                     {
                         ParentId = 4,
                         Title = "Pallet Conveyor",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                     new SubDescriptions
                     {
                         ParentId = 4,
                         Title = "Roller Bed Conveyor",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                     new SubDescriptions
                     {
                         ParentId = 4,
                         Title = "Slider Bed Conveyor",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                     new SubDescriptions
                     {
                         ParentId = 4,
                         Title = "Wire Mesh Belt Conveyor",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                     new SubDescriptions
                     {
                         ParentId = 5,
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                     new SubDescriptions
                     {
                         ParentId = 5,
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                     new SubDescriptions
                     {
                         ParentId = 5,
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                     new SubDescriptions
                     {
                         ParentId = 6,
                         Title = "Bridge System",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                      new SubDescriptions
                     {
                         ParentId = 6,
                         Title = "Free Standing Cantilevered Monorail",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                      new SubDescriptions
                     {
                         ParentId = 6,
                         Title = "Ceiling Mounted Monorail System",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                      new SubDescriptions
                     {
                         ParentId = 6,
                         Title = "Fold Away Systems",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                     new SubDescriptions
                     {
                         ParentId = 6,
                         Title = "Swing Arm Systems",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     },
                     new SubDescriptions
                     {
                         ParentId = 6,
                         Title = "Mobile Fall Protection Systems",
                         Descriptions = new List<string>
                         {
                             ""
                         }
                     }
            };
        }

        public IEnumerable<SubDescriptions> GetSubDescriptionsByParentId(int id)
        {
            return GetSubDescriptions().Where(s => s.ParentId == id);
        }
    }
}