using Centex.Models;
using Centex.Services.ServiceObjects.Interfaces;
using System;
using System.Collections.Generic;

namespace Centex.Services.ServiceObjects
{
    public enum ServiceCategories
    {
        Preventivemaintenance,
        Certifiedloadtest,
        Inspectionrepairs,
        Relocation,
        Modificationupgrades
    }

    public class Service : IService
    {
        private readonly IServicesDb _servicesDb;

        public Service (IServicesDb servicesDb)
        {
            _servicesDb = servicesDb;
        }

        public ServiceModel GetModel(ServiceCategories category)
        {
            switch (category)
            {
                case ServiceCategories.Preventivemaintenance:
                    return GetPreventiveMaintenance();
                case ServiceCategories.Certifiedloadtest:
                    return GetCertifiedLoadTest();
                case ServiceCategories.Inspectionrepairs:
                    return GetInspecitionRepairs();
                case ServiceCategories.Relocation:
                    return GetRelocation();
                case ServiceCategories.Modificationupgrades:
                    return GetModificationUpgrades();
                default:
                    throw new ArgumentOutOfRangeException(nameof(category), category, null);
            }
        }

        private ServiceModel GetPreventiveMaintenance()
        {
            return _servicesDb.GetServiceById(0);
        }

        private ServiceModel GetCertifiedLoadTest()
        {
            return _servicesDb.GetServiceById(1);
        }

        private ServiceModel GetInspecitionRepairs()
        {
            return _servicesDb.GetServiceById(2);
        }

        private ServiceModel GetRelocation()
        {
            return _servicesDb.GetServiceById(3);
        }

        private ServiceModel GetModificationUpgrades()
        {
            return _servicesDb.GetServiceById(4);
        }
    }
}