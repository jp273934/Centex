(function () {
    'use strict';

    app.controller('ContactController', function($scope, $http) {
        $scope.contact = {};
        $scope.isSendingMessage = false;
        $scope.isMessageSent = false;

        $scope.sendMessage = function () {
            $scope.isSendingMessage = true;

            $http.post('/api/Email/SendEmail', $scope.contact)
            .then(function (payload) {
                $scope.contact = {};
                    $scope.isMessageSent = true;
                });
        };

        
    });

})();
