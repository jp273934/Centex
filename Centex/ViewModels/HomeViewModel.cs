using Centex.Models;
using System.Collections.Generic;

namespace Centex.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Panel> Panels { get; set; }
        public IEnumerable<CatalogItem> CatalogItems { get; set; }
    }
}