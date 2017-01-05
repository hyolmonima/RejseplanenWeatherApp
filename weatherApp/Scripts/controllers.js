angular.module("AngularForDemo.controllers", []),
controller("AddPlayerController", function ($scope, PlayerService) {
        
    $scope.message = "Enter your details";

    $scope.AddPlayer = function()
    {
        PlayerService.AddPlayerToDB($scope.AddPlayer);
    }
})
.factory("PlayerService", ['$http', function ($http) {
    var fac = {};
    fac.AddPlayerToDB = function (player)
    {
        $http.post("/Player/AddPlayer", player).success(function (response) {
            alert(response.status);
        })
    }
    return fac;
}])
