favoriteVM = function () {
    var self = this;
    self.origin = ko.observable();
    self.destination = ko.observable();
    self.name = ko.observable("");

    self.loadUserData = function () {
        $.getJSON("/Home/GetTrip/", function (datas) {

            self.origin(datas.origin);
            self.destination(datas.destination);
            self.name(datas.TripList.Leg.origin.name);
        });
    };
};