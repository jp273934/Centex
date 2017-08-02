using System.Collections.Generic;

namespace Centex.Models
{
    public interface IItem
    {
        string Title { get; set; }
        IEnumerable<Photo> Photos { get; set; }
        Descriptions Descriptions { get; set; }
    }
}