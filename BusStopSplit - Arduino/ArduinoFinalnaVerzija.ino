//OSOBNI ALGORITAM!
// potrebni library-i za funkcioniranje arduina
#include <SPI.h>
#include <WiFi101.h>
#include<TinyGPS++.h>

TinyGPSPlus gps;
unsigned long lastSend;

double lat, lng;

char ssid[] = "infokup";        // ime internet mreže
char pass[] = "infokup1234";    // lozinka internet mreže
int keyIndex = 0;            

int status = WL_IDLE_STATUS;
char server[] = "busstop.amber-it.co";    // ime web-adrese servera


WiFiClient client;

// default-ne koordinate dok se sateliti ne spoje sa Arduino uređajem
void setup() {
    lastSend = 0;
    lat=0;
    lng=0;
    
  Serial.begin(9600);
  Serial1.begin(9600);

  // provjera ima li konekcije sa WiFi shield-om
  if (WiFi.status() == WL_NO_SHIELD) {
    Serial.println("WiFi shield not present");
    
    while (true);
  }

  // pokušaj konekcije na internet
  while (status != WL_CONNECTED) {
    Serial.print("Attempting to connect to SSID: ");
    Serial.println(ssid);
    status = WiFi.begin(ssid, pass);

    delay(10000);
  }
  Serial.println("Connected to wifi");
  printWiFiStatus();
}

// funkcija koja obavlja sav posao odnosno šalje koordinate na web-adresu stvarajući točku na karti
void loop() {

  while (Serial1.available() > 0){
    // get the byte data from the GPS
    byte gpsData = Serial1.read();
    gps.encode(gpsData);
    if (gps.location.isUpdated()){
      Serial.println("LocationUpdate");
      lat = gps.location.lat();
      lng = gps.location.lng();
    }
  }

  if(lastSend + 3000 < millis()){
    lastSend = millis();
    
    Serial.println("\nTrying to send coords...");
    // if you get a connection, report back via serial:

    if(!client.connected()){
      Serial.println("Not connected to server, connecting...");
      client.connect(server, 80);
    }
    
    if (client.connected()) {
      Serial.println("connected to server");
      // Make a HTTP request:
      client.print("GET /api/coordinates/updateForBus?busId=IK&lat=");
      client.print(lat, 6);
      client.print("&lng=");
      client.print(lng, 6);
      client.println(" HTTP/1.1");
      
      client.println("Host: busstop.amber-it.co");
      client.println();
    }
    Serial.println(lat, 6);
    Serial.println(lng, 6); 
  }
  
  while (client.available()) {
    char c = client.read();
    Serial.write(c);
  }
  
}

// ispis da je Arduino uspješno spojen na internet
void printWiFiStatus() {
  Serial.print("SSID: ");
  Serial.println(WiFi.SSID());

  // print your WiFi shield's IP address:
  IPAddress ip = WiFi.localIP();
  Serial.print("IP Address: ");
  Serial.println(ip);

  // print the received signal strength:
  long rssi = WiFi.RSSI();
  Serial.print("signal strength (RSSI):");
  Serial.print(rssi);
  Serial.println(" dBm");
}
