app.service("WeatherService" , function($http)
{
this.getWeatherData = function()
{
    debugger;
    return $http.get("/home/getweather");
}});