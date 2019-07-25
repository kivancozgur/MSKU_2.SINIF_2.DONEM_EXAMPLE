#include <SoftwareSerial.h>
#include <Wire.h>//Include libraries: SoftwareSerial & Wire
SoftwareSerial BT(11,12); //Define PIN11=TX & PIN12=RX
 
//RGB LED Pins
int PIN_RED = 6;
int PIN_GREEN = 5;
int PIN_BLUE = 3;
//RED LED at Pin 13
int RED_LED = 13;
String RGB = ""; //store RGB code from BT
String RGB_Previous = "255.255.255)"; //preserve previous RGB color for LED switch on/off, default White
String ON = "ON"; //Check if ON command is received
String OFF = "OFF"; //Check if OFF command is received
boolean RGB_Completed = false;
 
void setup() {
  Serial.begin(9600); //Arduino serial port baud rate：9600
  BT.begin(9600);//My HC-05 module default baud rate is 9600
  RGB.reserve(30);
 
  pinMode(RED_LED, OUTPUT); 
  //Set pin13 as output for LED, 
  // this LED is on Arduino mini pro, not the RGB LED
}
 
void loop() {
  // put your main code here, to run repeatedly: 
  
  //Read each character from Serial Port(Bluetooth)
  while(BT.available()){
    char ReadChar = (char)BT.read();
 
    // Right parentheses ) indicates complet of the string
    if(ReadChar == ')'){
      RGB_Completed = true;
    }else{
       RGB += ReadChar;
    }
  }
  
  //When a command code is received completely with ')' ending character
  if(RGB_Completed){
   //Print out debug info at Serial output window
      Serial.print("RGB:");
      Serial.print(RGB);
      Serial.print("     PreRGB:");
      Serial.println(RGB_Previous);
      
      if(RGB==ON){
          digitalWrite(13,HIGH);
          RGB = RGB_Previous; //We only receive 'ON', so get previous RGB color back to turn LED on
          Light_RGB_LED();          
 
      }else if(RGB==OFF){
          digitalWrite(13,LOW);
          RGB = "0.0.0)"; //Send OFF string to turn light off
          Light_RGB_LED();
      }else{
          //Turn the color according the color code from Bluetooth Serial Port
          Light_RGB_LED();   
          RGB_Previous = RGB;     
      }
      //Reset RGB String  
 
      RGB = "";
      RGB_Completed = false;
      
    
  } //end if of check if RGB completed
  
} // end of loop
 
void Light_RGB_LED(){
 
  int SP1 = RGB.indexOf('.');
  int SP2 = RGB.indexOf('.', SP1+1);
  int SP3 = RGB.indexOf('.', SP2+1);
  String R = RGB.substring(0, SP1);
  String G = RGB.substring(SP1+1, SP2);
  String B = RGB.substring(SP2+1, SP3);
 
  //Print out debug info at Serial output window
  Serial.print("R=");
  Serial.println( constrain(R.toInt(),0,255));
  Serial.print("G=");
  Serial.println(constrain(G.toInt(),0,255));
  Serial.print("B=");
  Serial.println( constrain(B.toInt(),0,255));
  //Light up the LED with color code
 
//**2014-09-21
//Because these RGB LED are common anode (Common positive)
//So we need to take 255 to minus R,G,B value to get correct RGB color code
  analogWrite(PIN_RED,  (255-R.toInt()));
  analogWrite(PIN_GREEN, (255-G.toInt()));
  analogWrite(PIN_BLUE,  (255-B.toInt()));
 
}
