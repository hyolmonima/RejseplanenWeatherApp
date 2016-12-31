var App = angular.module('App', []);
App.controller('TripController', function ($scope,$http ,TripService) {

    getTrips();
    function getTrips() {
        TripService.getTrips()
            .success(function (tripData) {
                $scope.trips = tripData;
                console.log($scope.trips);
            })
            .error(function (error) {
                $scope.status = 'Unable to load customer data: ' + error.message;
                console.log($scope.status);
            });
    }

    $scope.userQuery = function (originId, destinationId) {
     return $http.get('/Home/GetTrip',originId, destinationId)
       .success(function (tripData1) {
           $scope.trips1 = tripData1;
           console.log($scope.trips1);
       })
    };
});

App.controller('RejseController', function ($scope, $http, RejseService) {

    getTrips();
    function getTrips() {
        RejseService.getTrips()
            .success(function (tripData) {
                $scope.trips = tripData;
                console.log($scope.trips);
            })
            .error(function (error) {
                $scope.status = 'Unable to load customer data: ' + error.message;
                console.log($scope.status);
            });
    }

    $scope.userQuery = function (originId, destinationId) {
        return $http.get('/Rejse/DataReceiver?origin='+ originId+'&destination='+ destinationId+'&format=json')
          .success(function (tripData1) {
              $scope.trips1 = tripData1;
              console.log($scope.trips1);
          })
    };

    $scope.weatherQuery = function (wDest) {
        return $http.get('/Weather/GetWeather?wDestination='+ wDest)
          .success(function (wData) {
              $scope.data1 = wData;
              console.log($scope.data1);
          })
    };

    $scope.recommendationQuery = function (weatherDescription, temp, wind) {
        return $http.post('/Recommendation/recommendation?weatherDescription=' + weatherDescription +"&temp="+temp+"&wind="+wind)
          .success(function (rData) {
              $scope.data2 = rData;
              console.log($scope.data2);
          })
    };
});

App.factory('RejseService', ['$http', function ($http) {

    var RejseService = {};
    RejseService.getTrips = function () {
        return $http.get('/Rejse/GetTrip');
    };
    return RejseService;

}]);

//App.factory('TripService', ['$http', function ($http) {

//    var TripService = {};
//    TripService.getTrips = function () {
//        return $http.get('/Rejse/GetTrip');
//    };
//    return TripService;

//}]);

