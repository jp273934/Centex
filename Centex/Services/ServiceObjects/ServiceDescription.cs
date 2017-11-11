using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Centex.Services.ServiceObjects
{
    public class ServiceDescription
    {
        public string Description { get; set; }
        public IEnumerable<string> Items { get; set; }
    }
}