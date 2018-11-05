app.controller('MapController', function ($scope) {

    $scope.initialize = function () {
        var myCenter = new google.maps.LatLng(30.602771, -97.841645);
        var mapCanvas = document.getElementById("googleMap");
        var mapOptions = { center: myCenter, zoom: 12 };
        var map = new google.maps.Map(mapCanvas, mapOptions);
        var marker = new google.maps.Marker({ position: myCenter });
        marker.setMap(map);

        var infowindow = new google.maps.InfoWindow({
            content: "<p>Centex Material Handling</p><p>1055 CR 270</p><p>Leander, Texas 78641</p>"
        });
        infowindow.open(map, marker);
    };

    $scope.loadScript = function () {
        var script = document.createElement('script');
        script.type = 'text/javascript';
        script.src = 'https://maps.googleapis.com/maps/api/js?key=AIzaSyD0WBPBCC3V5FlMU4E_txU2cZ8O9_v0rUY&callback=initialize';
        document.body.appendChild(script);
        setTimeout(function () {
            $scope.initialize();
        }, 500);
    };

}).directive('mapPanel', function () {
    return {
        templateUrl: '/app/Contact/map.html'
    };
});