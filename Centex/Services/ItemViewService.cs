using Centex.Models;
using Centex.Services.Products.Interfaces;
using Centex.Services.ServiceObjects.Interfaces;
using Centex.ViewModels;
using System;

namespace Centex.Services
{
    public class ItemViewService : IItemViewService
    {
        private readonly IProductService _productService;
        private readonly IService _service;

        public ItemViewService(IProductService productService, IService service)
        {
            _productService = productService;
            _service = service;
        }

        public IITemViewModel GetViewModel(Categories.ItemType type, int itemId)
        {
            switch (type)
            {
                case Categories.ItemType.Product:
                    return _productService.GetProduct((Categories.ProductCategories) itemId);
                case Categories.ItemType.Service:
                    return new ProductViewModel();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}