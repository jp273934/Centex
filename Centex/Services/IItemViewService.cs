using Centex.Models;
using Centex.ViewModels;

namespace Centex.Services
{
    public interface IItemViewService
    {
        IITemViewModel GetViewModel(Categories.ItemType type, int itemId);
    }
}