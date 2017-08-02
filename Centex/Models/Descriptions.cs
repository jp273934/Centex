using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Centex.Models
{
    public class Descriptions
    {
        public int Id { get; set; }
        public IEnumerable<string> MainDescriptions { get; set; }
        public IEnumerable<SubDescriptions> SubDescriptions { get; set; }
    }
}