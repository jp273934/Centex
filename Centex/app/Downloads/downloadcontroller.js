app.controller('DownloadController', function ($scope) {
    $scope.download = function () {
        window.open('/api/download', '_blank', '');
    };
});