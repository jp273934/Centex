using System.Collections.Generic;

namespace Centex.Models
{
    public class SubDescriptions
    {
        public int ParentId { get; set; }
        public string Title { get; set; }
        public IEnumerable<string> Descriptions { get; set; }
        public IEnumerable<string> ListDescriptions { get; set; }
    }
}