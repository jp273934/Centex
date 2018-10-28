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
                     MainDescriptions = new List<SingleDescription>
                     {
                         new SingleDescription
                         {
                             DescriptionBody = "Pallet Racking is a storage system that increases the capacity of your existing warehouse, improves the overall workflow and efficiency, and leads to a more organized shop, factory, warehouse, distribution or logistics center."
                         },
                         new SingleDescription
                         {
                             DescriptionBody = "CMH specializes in warehouse pallet racking systems and warehouse shelving. Our Selective Pallet Racks, Structural Pallet Racks, Cantilever Racks, Drive-In Pallet Racks, Push-Back Racks, Carton Flow Racks, Pallet Flow Racks. Each of these racking systems serve a similar purpose, but vary in functionality and application. Depending on available space in your facility and style of inventory management, you will find the perfect warehouse racking for your facility here at Centex Material Handling."
                         }
                     }
                },
                new Descriptions
                {
                    Id = 1,              
                    MainDescriptions = new List<SingleDescription>
                    {
                        new SingleDescription
                        {
                            DescriptionBody = "CMH designs, manufactures, installs and services complete overhead material handling systems and stocks hoists, trolleys, accessories, replacement parts and provides service for most major brands.",
                            Bullets = new List<string>
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
                                }
        },
                        new SingleDescription
                        {
                            DescriptionBody = "We design, manufacture and install complete overhead material handling systems. Bridge cranes, Hoists, Chain Hoists, Wire Rope Hoists, Air Hoists, pendant controls, Radio controls. Top Running Single Girder, Under Running Single Girder, Top Running Double Girder, Under Running Double Girder, Gantry Crane, Single Leg Gantry Crane, Floor Mount Jib Crane, Wall Mount Jib Cranes, Free Standing Work Stations."
                        }
                    }
                },
                new Descriptions
                {
                    Id = 2,                   
                    MainDescriptions = new List<SingleDescription>
                    {
                        new SingleDescription
                        {
                            DescriptionBody = "CMH supplies and installs a full range of dock equipment. Whether your company requires simple dock bumpers and accessories or a complete in-pit leveler and truck restraint, count on CMH to help you get the right equipment for your needs."
                        }
                    }
                },
                new Descriptions 
                {
                    Id = 3,                   
                    MainDescriptions = new List<SingleDescription>
                    {
                        new SingleDescription
                        {
                            DescriptionBody = "CMH offers a variety of warehouse shelving solutions including boltless shelving, archive shelving, bulk rack shelving, and chrome wire shelving. Boltless and archive shelving are easy to install with little to no hardware required, and can be easily customized to fit your facility and needs. Chrome wire shelving is perfect for organization while maintaining air circulation and light. These shelves are also very easy to assemble, easy to expand as your needs grow, and help keep your inventory and items fully visible. Bulk racks are ideal for multi-level storage of hardware, tools, and heavy duty items. Bulk racking is available in various configurations, and come standard with particle board decking with the optional upgrade to wire mesh decking."
                        }
                    }
                },
                new Descriptions
                {
                    Id = 4,                   
                    MainDescriptions = new List<SingleDescription>
                    {
                        new SingleDescription
                        {
                            DescriptionBody = "A conveyor system is a common piece of mechanical handling equipment that moves materials from one location to another. Conveyors are especially useful in applications involving the transportation of heavy or bulky materials. Conveyor systems allow quick and efficient transportation for a wide variety of materials, which make them very popular in the material handling and packaging industries. Many kinds of conveying systems are available, and are used according to the various needs of different industries."
                        }
                    }
                },
                new Descriptions
                {
                    Id = 5,                   
                    MainDescriptions = new List<SingleDescription>
                    {
                        new SingleDescription
                        {
                            DescriptionBody = "Warehouse mezzanines and catwalks allow you to greatly increase the utilization of your square footage. Increase space efficiency and organization of your facility with a catwalk or mezzanine platform. Warehouse Mezzanines efficiently use the height of a facility, while doubling or even tripling the surface area. Mezzanines can be the most economical way to increase warehouse space without having to expand or relocate from Southern California. There are many important factors to consider when designing a mezzanine, including access-ways, work systems, products, and handling methods in order to plan accurately. Mezzanines may be completely disassembled; the parts re-used; and the structure, dimensions, and location easily modified."
                        }
                    }
                },
                new Descriptions
                {
                    Id = 6,
                    MainDescriptions = new List<SingleDescription>
                    {
                        new SingleDescription
                        {
                            DescriptionBody = "A Fall Arrest System is an active means of protecting workers from injury due to falls. A complete personal fall arrest system includes an anchor, a body harness and a connector- such as a shock-absorbing fall arrest lanyard or self-retracting lanyard (SRL). "
                        },
                        new SingleDescription
                        {
                            DescriptionBody = "Using a Rigid Rail Fall Arrest System as your anchor provides workers with a high degree of mobility and freedom, while preventing falls to lower levels. Standard systems are designed to accommodate multiple workers, each weighing up to 310 pounds with tools."
                        },
                        new SingleDescription
                        {
                            DescriptionBody = "A Rigid Rail Fall Arrest Systems provide a reliable and cost-effective solution for reducing the risk of injury in elevated work environments. Available in various configurations, including multiple track profiles and support center distances, fall protection can be easily customized to fit every budget and application. All systems are designed by qualified engineers to meet the OSHA 1926 Subpart M construction standard, as well as the ANSI Z359 Fall Protection code."
                        }
                    }
                },
                new Descriptions
                {
                    Id = 7,
                    MainDescriptions = new List<SingleDescription>
                    {
                        new SingleDescription
                        {
                            DescriptionBody = "Our DCS-Pro chain hoists ensure maximum precision in gently and safely lifting, lowering and positioning valuable and sensitive parts in assembly operations. Our almost double rated partial load range speed enables lifting motions to be performed more reliably, quickly and efficiently."
                        }
                    }
                },
                new Descriptions
                {
                    Id = 8,
                    MainDescriptions = new List<SingleDescription>
                    {
                        new SingleDescription
                        {
                            DescriptionBody = "The DCM-Pro Manulift enables you to handle loads quickly and safely with only one hand. The DCM-Pro is based on the lifting unit of the DC-Pro chain hoist and the DSM-C control unit. Thanks to the control unit which is rigidly connected to the load handling attachment, the operator only needs one hand to operate the hoist and guide the load."
                        }
                    }
                },
                new Descriptions
                {
                    Id = 9,
                    MainDescriptions = new List<SingleDescription>
                    {
                        new SingleDescription
                        {
                            DescriptionBody = "Gorbel's G-Force® Intelligent Lifting Devices enable operators to lift and maneuver naturally, as if the devices were an extension of their arms. There are two G-Force® models to choose from: the Q and the iQ. The Q model is our feature packed base model. It offers the same speed and precision as our higher-end iQ model, but without the added Input/Output features that the iQ offers. The iQ model offers a wealth of additional intelligence features. "
                        },
                        new SingleDescription
                        {
                            DescriptionBody = "Gorbel's G-Force® Intelligent Lifting Devices enable operators to lift and maneuver naturally, as if the devices were an extension of their arms. There are two G-Force® models to choose from: the Q and the iQ. The Q model is our feature packed base model. It offers the same speed and precision as our higher-end iQ model, but without the added Input/Output features that the iQ offers. The iQ model offers a wealth of additional intelligence features. "
                        }
                    }
                }
            };
        }

        public IEnumerable<SingleDescription> GetDescriptionsById(int id)
        {
            return GetDescriptions().First(d => d.Id == id).MainDescriptions;
        }
    }
}