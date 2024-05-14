// Realtime komunikacija pomoću SignalR-a

"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/busHub").build();

connection.on("ReceiveMessage", function (busId, latitude, longitude) {

    window.setMarkerPosition(busId, latitude, longitude);
});

connection.start().then(function () {

}).catch(function (err) {
    return console.error(err.toString());
});
