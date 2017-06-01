using System.Collections.Generic;

namespace Centex.Models
{
    public class Product
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public IEnumerable<string> Descriptions { get; set; }
        public IEnumerable<string> ListDescriptions { get; set; }
    }
}