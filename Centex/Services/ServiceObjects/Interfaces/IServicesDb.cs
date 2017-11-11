using Centex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centex.Services.ServiceObjects.Interfaces
{
    public interface IServicesDb
    {
        ServiceModel GetServiceById(int id);
    }
}
