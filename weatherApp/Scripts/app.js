var app = angular.module("AngularFormDemo", ["AngularFormDemo.controllers", "ngRoute"]);

app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider.
        when("/", {
            templateUrl: "/Partials/AddPlayer.html",
            controller:"AddPlayerController"
        }),
    otherwise({redirectTo: "/"})
}]);