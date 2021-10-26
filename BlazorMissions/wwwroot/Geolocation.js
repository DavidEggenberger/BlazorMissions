function getLocation() {
    if (navigator.geolocation) {
        return navigator.geolocation.getCurrentPosition(returnPosition);
    }
}
function returnPosition(position) {
    DotNet.invokeMethod('BlazorMissions', 'SetUserLocation', position.coords.latitude, position.coords.longitude);
}