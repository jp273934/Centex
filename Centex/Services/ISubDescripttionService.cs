using System.Collections.Generic;
using Centex.Models;

namespace Centex.Services
{
    public interface ISubDescripttionService
    {
        IEnumerable<SubDescriptions> GetSubDescriptionsByParentId(int id);
    }
}