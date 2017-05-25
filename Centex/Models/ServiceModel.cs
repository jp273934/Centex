using System.Collections.Generic;

namespace Centex.Models
{
    public class ServiceModel
    {
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public IEnumerable<string> Descriptions { get; set; }
    }
}