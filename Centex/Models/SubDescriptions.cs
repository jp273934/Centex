using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Centex.Models
{
    public class SubDescriptions
    {
        public int ParentId { get; set; }
        public IEnumerable<string> Descriptions { get; set; }
    }
}