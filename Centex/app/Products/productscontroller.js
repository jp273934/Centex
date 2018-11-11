app.controller('ProductController', function ($scope, $routeParams) {
    $scope.productPath = '';

    getProductPath();

    function getProductPath() {
        var rootPath = '/app/Products/';

        switch ($routeParams.id) {
            case 'overheadcranes':
                $scope.productPath = rootPath + 'overheadcranes.html';
                break;
            case 'palletracks':
                $scope.productPath = rootPath + 'palletracks.html';
                break;
            case 'loadingdockequipment':
                $scope.productPath = rootPath + 'loadingdockequipment.html';
                break;
            case 'shelving':
                $scope.productPath = rootPath + 'shelving.html';
                break;
            case 'conveyors':
                $scope.productPath = rootPath + 'conveyors.html';
                break;
            case 'warehousemezzanines':
                $scope.productPath = rootPath + 'warehousemezzanines.html';
                break;
            case 'fallprotectionsystems':
                $scope.productPath = rootPath + 'fallprotectionsystems.html';
                break;
            case 'demagdcspro':
                $scope.productPath = rootPath + 'demagdcspro.html';
                break;
            case 'demagdcmpromanulift':
                $scope.productPath = rootPath + 'demagdcmpromanulift.html?version=1';
                break;
            case 'gorbelgforce':
                $scope.productPath = rootPath + 'gorbelgforce.html';
                break;
            case 'platformsandladders':
                $scope.productPath = rootPath + 'platformsandladders.html';
                break;
            case 'main':
                $scope.productPath = rootPath + 'productselection.html';
                break;
        }
    }
});