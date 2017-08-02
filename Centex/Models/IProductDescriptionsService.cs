using System.Collections.Generic;

namespace Centex.Models
{
    public interface IProductDescriptionsService
    {
        IEnumerable<string> GetDescriptionsById(int id);
    }
}