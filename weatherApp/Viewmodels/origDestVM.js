define(["knockout"], function (ko) {
    return function (params) {

        var tripData = ko.observableArray([]);

        var callback = function (data) {
            tripData(data.data);
            
        };

        db.tripData(callback);

        return {
            tripData: tripData,
            
        };
    };
});
