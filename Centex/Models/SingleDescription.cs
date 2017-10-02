using System.Collections.Generic;

namespace Centex.Models
{
    public class SingleDescription
    {
        public string DescriptionBody { get; set; }
        public IEnumerable<string> Bullets { get; set; }
    }
}