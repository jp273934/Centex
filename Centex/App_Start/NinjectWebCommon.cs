using Centex.Data;
using Centex.Models;
using Centex.Services;
using Centex.Services.Catalog;
using Centex.Services.Catalog.Interfaces;
using Centex.Services.Contact;
using Centex.Services.Contact.Interfaces;
using Centex.Services.Home;
using Centex.Services.Home.Interfaces;
using Centex.Services.Products;
using Centex.Services.Products.Interfaces;
using Centex.Services.ServiceObjects;
using Centex.Services.ServiceObjects.Interfaces;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Centex.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Centex.App_Start.NinjectWebCommon), "Stop")]

namespace Centex.App_Start
{
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using System;
    using System.Web;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IHomeViewModelService>().To<HomeViewModelService>();
            kernel.Bind<IService>().To<Service>();
            kernel.Bind<IProductService>().To<ProductService>();
            kernel.Bind<IEmailService>().To<EmailService>();
            kernel.Bind<IPanelService>().To<PanelService>();
            kernel.Bind<ICatalogService>().To<CatalogService>();
            kernel.Bind<IItemViewService>().To<ItemViewService>();
            kernel.Bind<IProductsDb>().To<ProductsDb>();
            kernel.Bind<ISubDescripttionService>().To<SubDescripttionService>();
            kernel.Bind<IProductDescriptionsService>().To<ProductDescriptionsService>();
            kernel.Bind<IProductImagesDb>().To<ProductImagesDb>();
            kernel.Bind<IServicesDb>().To<ServicesDb>();
        }        
    }
}
