using Centex.Models;

namespace Centex.Data
{
    public interface IProductsDb
    {
        Product GetProductById(int id);
    }
}