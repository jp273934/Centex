using Centex.Models;

namespace Centex.Services.Products.Interfaces
{
    public interface IProductService
    {
        Product GetProduct(ProductCategories category);
    }
}