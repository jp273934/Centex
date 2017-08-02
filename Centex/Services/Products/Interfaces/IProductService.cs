using Centex.Models;
using Centex.ViewModels;

namespace Centex.Services.Products.Interfaces
{
    public interface IProductService
    {
        ProductViewModel GetProduct(Categories.ProductCategories category);
    }
}