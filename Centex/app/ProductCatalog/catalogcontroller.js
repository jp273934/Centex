app.controller('CatalogController', function ($scope, $sce) {
    $scope.catalogUrl = '';

    getCatalogUrl();

    function getCatalogUrl() {
        var rootPath = 'https://centexmaterialhandling.theonlinecatalog.com/store/';

        var urlParameter = new URLSearchParams(location.search);

        switch (urlParameter.get('type')) {
            case 'bins':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'bins');
                break;
            case 'boxes':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'boxes');
                break;
            case 'cabinets':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'cabinets');
                break;
            case 'carts':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'carts');
                break;
            case 'casters':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'casters');
                break;
            case 'chairsstools':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'chairs-and-stools');
                break;
            case 'containers':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'containers');
                break;
            case 'cranes':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'cranes');
                break;
            case 'conveyors':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'conveyors');
                break;
            case 'dockequipment':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'dock-equipment');
                break;
            case 'dollies':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'dollies');
                break;
            case 'doors':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'doors');
                break;
            case 'drumsequipment':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'drums-and-equipment');
                break;
            case 'dumper':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'dumper');
                break;
            case 'ergonomic':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'ergonomic');
                break;
            case 'forkequipment':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'fork-equipment');
                break;
            case 'guards':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'guards');
                break;
            case 'handtrucks':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'hand-trucks');
                break;
            case 'hoistsequipment':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'hoists-and-equipment');
                break;
            case 'hoppers':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'hoppers');
                break;
            case 'hosecordreels':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'hose-and-cord-reels');
                break;
            case 'ladders':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'ladders');
                break;
            case 'liftingequipment':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'lifts-/-lifting-equipment');
                break;
            case 'lockers':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'lockers');
                break;
            case 'matting':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'matting');
                break;
            case 'officefurniture':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'office-furniture');
                break;
            case 'palletsequipment':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'pallets-and-equipment');
                break;
            case 'partitions':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'partitions');
                break;
            case 'platforms':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'platforms');
                break;
            case 'racks':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'racks');
                break;
            case 'reels':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'reels');
                break;
            case 'safetyequipment':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'safety-equipment');
                break;
            case 'scales':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'scales');
                break;
            case 'securityequipment':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'security-equipment');
                break;
            case 'shelving':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'shelving');
                break;
            case 'shippingsupplies':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'shipping-supplies');
                break;
            case 'strapping':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'strapping');
                break;
            case 'structuralframing':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'structural-framing');
                break;
            case 'tables':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'tables');
                break;
            case 'tools':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'tools');
                break;
            case 'trucks':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'trucks');
                break;
            case 'warehouseequipment':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'warehouse-equipment');
                break;
            case 'wire':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'wire');
                break;
            case 'workbenches':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'work-benches');
                break;
            case 'store':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath + 'store');
                break;
            case 'main':
                $scope.catalogUrl = $sce.trustAsResourceUrl(rootPath);
                break;
        }
    }
});