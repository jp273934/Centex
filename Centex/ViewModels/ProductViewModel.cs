using Centex.Models;
using System.Collections.Generic;

namespace Centex.ViewModels
{
    public class ProductViewModel : IITemViewModel
    {
        public string Title { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
        public IEnumerable<string> ListDescriptions { get; set; }
        public Categories.ItemType ProductType { get; set; }
        public Product Product { get; set; }
        public int CatalogId { get; set; }
    }
}