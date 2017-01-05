app.controller("WeatherCtrl" , function ($scope, WeatherService) 
{
    GetWeather();
    function GetWeather()
    {
    
        var getWeather = Service.getWeatherData();
        getWeather.then(function (wdata)
        {
            $scope.Weather = wdata.data;
        }, function()
        {
            alert('Data Not Found');
        });
    }
});