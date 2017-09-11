var taxiFareAppModule = angular.module("taxiFareApp", []); 

//Service
taxiFareAppModule.factory('taxiFareService', ['$http', function ($http) {
    return {
        getTaxiFare: function (data) {
            return $http({
                method: 'POST',
                url: '/Home/CalculateFare',
                data: $.param(data),
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }
    }
}]);

//Controller
taxiFareAppModule.controller('taxiFareController', function ($scope, taxiFareService) {

    $scope.rideStartDateTime = new Date();
    
    $scope.CalculateFare = function () {

        var data = {
            numberOfMilesDrivenBelow6mph: $scope.numberOfMilesDrivenBelow6mph,
            numberOfMinutesDrivenAbove6mph: $scope.numberOfMinutesDrivenAbove6mph,
            rideStartDateTime: new Date($scope.rideStartDateTime.getYear(), $scope.rideStartDateTime.getMonth(), $scope.rideStartDateTime.getDate(), $scope.rideStartDateTime.getHours(), $scope.rideStartDateTime.getMinutes()).toUTCString(),
            rideStartLocation: $scope.rideStartLocation,
            rideEndLocation: $scope.rideEndLocation
        };

        taxiFareService.getTaxiFare(data).then(function (result) {
            var jsonData = JSON.parse(result.data);
            $scope.totalFare = jsonData.TotalFare;
        }, function (data) {
            console.error(data);
        });

    };
});

//Number validation directive
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

//HTML element directive
taxiFareAppModule.directive("projectTitle", function () {
    return {
        restrict: "E",
        template: "<h1>Taxi Fare Calculator</h1>"
    };
});