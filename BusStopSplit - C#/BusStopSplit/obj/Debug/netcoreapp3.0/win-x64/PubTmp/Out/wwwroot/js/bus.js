"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/busHub").build();

//Disable send button until connection is established
//document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (busId, latitude, longitude) {
    //var msg = latitude.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    //var encodedMsg = busId + " has " + msg + " and " + longitude;
    //var li = document.createElement("li");
    //li.textContent = encodedMsg;
    //document.getElementById("messagesList").appendChild(li);
    //console.log(latitude);
    //console.log(longitude);
    //var newLatLng = new L.LatLng(latitude, longitude);
    //window.marker.setLatLng(newLatLng);
    window.setMarkerPosition(busId, latitude, longitude);
});

connection.start().then(function () {
    //document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

//document.getElementById("sendButton").addEventListener("click", function (event) {
//    var busId = document.getElementById("busIdInput").value;
//    var latitude = document.getElementById("latitudeInput").value;
//    var longitude = document.getElementById("longitudeInput").value;
//    connection.invoke("SendMessage", busId, latitude, longitude).catch(function (err) {
//        return console.error(err.toString());
//    });
//    event.preventDefault();
//});

