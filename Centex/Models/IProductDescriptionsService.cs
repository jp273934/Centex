using System.Collections.Generic;

namespace Centex.Models
{
    public interface IProductDescriptionsService
    {
        IEnumerable<SingleDescription> GetDescriptionsById(int id);
    }
}