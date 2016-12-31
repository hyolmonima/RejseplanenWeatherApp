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

    $scope.originQuery = function (originString) {
        return $http.get('/Location/OriginLocationService?originString=' + originString + '&format=json')
          .success(function (originData) {
              $scope.origin = originData;
              console.log($scope.origin);
          })
    };

    $scope.destinationQuery = function (destinationString) {
        return $http.get('/Location/DestinationLocationService?destinationString=' + destinationString + '&format=json')
          .success(function (destinationData) {
              $scope.destination = destinationData;
              console.log($scope.destination);
          })
    };

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

App.factory('LocationService', ['$http', function ($http) {

    var LocationService = {};
    LocationService.getLocations = function (location) {
        return $http.getJSON('http://xmlopen.rejseplanen.dk/bin/rest.exe/location?input='+ location);
    };
    return LocationService;

}]);

