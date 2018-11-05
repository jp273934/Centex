
    app.controller('ContactController', function($scope, $http) {
        $scope.contact = {};
        $scope.isSendingMessage = false;
        $scope.isMessageSent = false;
        $scope.showPanel = true;
        $scope.isSubmitted = false;

        $scope.sendMessage = function () {
            $scope.isSubmitted = true;

            if ($scope.ContactForm.$valid) {
                $scope.isSendingMessage = true;
                $scope.showPanel = false;

                $http.post('/api/Email/SendEmail', $scope.contact)
                .then(function (payload) {
                    $scope.contact = {};
                    $scope.isMessageSent = true;
                    $scope.isSendingMessage = false;
                });
            }          
        };        
    }).directive('contactPanel', function () {
        return {
            templateUrl: '/app/Contact/contactpanel.html'
        };
    });

