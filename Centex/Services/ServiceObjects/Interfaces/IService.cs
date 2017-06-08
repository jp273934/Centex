using Centex.Models;

namespace Centex.Services.ServiceObjects.Interfaces
{
    public interface IService
    {
        ServiceModel GetModel(ServiceCategories category);
    }
}