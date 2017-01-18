var App = angular.module('App', []);
App.controller('TripController', function ($scope, $http) {

    $scope.originQuery = function (originString) {
        return $http.get('/Location/OriginLocationService?originString=' + originString)
          .success(function (originData) {
              $scope.origin = originData;
              console.log($scope.origin);
          });
    };

    $scope.destinationQuery = function (destinationString) {
        return $http.get('/Location/DestinationLocationService?destinationString=' + destinationString)
          .success(function (destinationData) {
              $scope.destination = destinationData;
              console.log($scope.destination);
          });
    };

    $scope.userQuery = function (originId, destinationId) {
        return $http.get('/Trip/GetTrip?origin=' + originId + '&destination=' + destinationId)
          .success(function (tripData1) {
              $scope.trips1 = tripData1;
              var lastItem = tripData1.TripList.Trip.slice(-1)[0];
              var destination = lastItem.Leg.slice(-1)[0];
              var destinationName = destination.Destination.name;
              $scope.finalDestination = destinationName;
              $http.get('/Weather/GetWeather?wDestination=' + destinationName)
          .success(function (wData1) {
              $scope.destinationWeather = wData1;
              console.log($scope.destinationWeather);
              console.log($scope.destinationName);
              console.log($scope.trips1);
          });
          });
    };

    $scope.weatherQueryByCoordinates = function (x, y) {
        return $http.get('/Weather/GetWeatherByCoordinates?x=' + x + '&y=' + y)
          .success(function (wDataByCoord) {
              $scope.wDataByCoord = wDataByCoord;
              console.log($scope.wDataByCoord);
          });
    };

    $scope.weatherQuery = function (wDest) {
        return $http.get('/Weather/GetWeather?wDestination=' + wDest)
          .success(function (wData) {
              $scope.data1 = wData;
              console.log($scope.data1);
          });
    };

    $scope.recommendationQuery = function (weatherDescription, temp, wind) {
        return $http.post('/Recommendation/recommendation?weatherDescription=' + weatherDescription + "&temp=" + temp + "&wind=" + wind)
          .success(function (rData) {
              $scope.data2 = rData;
              console.log($scope.data2);
          });
    };

    $scope.visibleWeather = true;
    $scope.toggleWeather = function () {
        $scope.visibleWeather = !$scope.visibleWeather;
    };

    $scope.visible = true;
    $scope.toggleTrip = function () {
        $scope.visible = $scope.visible ? false : true;
    };
});
