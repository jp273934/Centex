using Centex.Services.ServiceObjects;
using System.Collections.Generic;

namespace Centex.Models
{
    public class ServiceModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<ServiceDescription> Descriptions { get; set; }
        public IEnumerable<string> Images { get; set; }
    }
}