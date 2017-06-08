using Centex.Services.Catalog.Interfaces;
using Centex.Services.Home.Interfaces;
using Centex.ViewModels;

namespace Centex.Services.Home
{
    public class HomeViewModelService : IHomeViewModelService
    {
        private readonly HomeViewModel _model;
        private readonly IPanelService _panelService;
        private readonly ICatalogService _catalogService;

        public HomeViewModelService(IPanelService panelService, ICatalogService catalogService)
        {
            _panelService = panelService;
            _catalogService = catalogService;
            _model = new HomeViewModel();
        }

        public HomeViewModel GetModel()
        {
            _model.Panels = _panelService.GetPanels();
            _model.CatalogItems = _catalogService.GetCatalogItems();

            return _model;
        }

        

        
    }
}