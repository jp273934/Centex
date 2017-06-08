using Centex.Models;
using System.Collections.Generic;

namespace Centex.Services.Catalog.Interfaces
{
    public interface ICatalogService
    {
        CatalogItem GetCataLogItemById(int id);
        IEnumerable<CatalogItem> GetCatalogItems();
    }
}