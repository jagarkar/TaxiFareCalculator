var taxiFareAppModule = angular.module("taxiFareApp", []); 
taxiFareAppModule.controller('taxiFareController', function ($scope, $http) {
    $scope.rideStartDateTime = new Date();

    $scope.CalculateFare = function () {

        var data = {
            numberOfMilesDrivenBelow6mph: $scope.numberOfMilesDrivenBelow6mph,
            numberOfMinutesDrivenAbove6mph: $scope.numberOfMinutesDrivenAbove6mph,
            rideStartDateTime: $scope.rideStartDateTime,
            rideStartLocation: $scope.rideStartLocation,
            rideEndLocation: $scope.rideEndLocation
        };

        $http.post('/Home/CalculateFare', data)
            .then(function (result) {
                var jsonData = JSON.parse(result.data);
                $scope.totalFare = jsonData.TotalFare;
            });
    };
});

taxiFareAppModule.directive('numbersOnly', function () {
    return {
        require: 'ngModel',
        link: function (scope, element, attr, ngModelCtrl) {
            ngModelCtrl.$parsers.push(fromUser);

            function fromUser(text) {
                if (text) {
                    var transformedInput = text.replace(/[^0-9]/g, '');

                    if (transformedInput !== text) {
                        ngModelCtrl.$setViewValue(transformedInput);
                        ngModelCtrl.$render();
                    }
                    return transformedInput;
                }
                return undefined;
            }
            
        }
    };
});

taxiFareAppModule.directive("projectTitle", function () {
    return {
        restrict: "E",
        template: "<h1>Taxi Fare Calculator</h1>"
    };
});