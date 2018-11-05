app.controller('ServiceController', function ($scope, $routeParams) {
    $scope.servicePath = '';

    getServiceSource();

    function getServiceSource()
    {
        var rootPath = '/app/Services/';

        switch ($routeParams.id) {
            case 'preventivemaintenance':
                $scope.servicePath = rootPath + 'preventativemainenance.html';
                break;
            case 'loadtest':
                $scope.servicePath = rootPath + 'loadtest.html';
                break;
            case 'inspectionandrepairs':
                $scope.servicePath = rootPath + 'inspectionandrepairls.html';
                break;
            case 'relocation':
                $scope.servicePath = rootPath + 'relocation.html';
                break;
            case 'modernizationandupgrades':
                $scope.servicePath = rootPath + 'modernizationandupgrades.html';
                break;
        }
    }
});