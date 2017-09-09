var app = angular.module("taxiFareApp", []); 
app.controller('taxiFareController', function ($scope, $http) {
    $scope.CalculateFare = function () {

        var data = {
            rideStartDate: $scope.rideStartDate,
            rideStartTime: $scope.rideStartTime,
            numberOfMilesDrivenBelow6mph: $scope.numberOfMilesDrivenBelow6mph,
            numberOfMinutesDrivenAbove6mph: $scope.numberOfMinutesDrivenAbove6mph,
            //rideStartLocation: $scope.rideStartLocation,
            //rideEndLocation: $scope.rideEndLocation,
            rideStartDateTime: $scope.rideStartDateTime  
        };

        $http.post('/Home/CalculateFare', data)
            .then(function (data) {
                $scope.totalFare = data.TotalFare;
            });
    }; 
});