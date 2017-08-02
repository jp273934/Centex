using System.Collections.Generic;

namespace Centex.Models
{
    public class Product : IItem
    {
        public int Id { get; set; }
        public string Title { get; set; }       
        public IEnumerable<Photo> Photos { get; set; }
        public IEnumerable<string> ModalIds { get; set; }
        public Descriptions Descriptions { get; set; }
        public int CatalogId { get; set; }
    }
}