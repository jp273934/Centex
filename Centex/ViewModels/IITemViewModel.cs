using System.Collections.Generic;
using Centex.Models;

namespace Centex.ViewModels
{
    public interface IITemViewModel
    {
        string Title { get; set; }
        IEnumerable<Photo> Photos { get; set; }
        Categories.ItemType ProductType { get; set; }
    }
}