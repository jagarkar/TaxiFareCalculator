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