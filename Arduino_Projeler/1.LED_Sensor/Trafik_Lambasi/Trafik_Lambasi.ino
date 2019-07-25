int ledPin = 13;
int ledPinSari = 8;
int ledPinYesil = 9;
void setup()
{ 
  pinMode(ledPin,OUTPUT);
  pinMode(ledPinYesil,OUTPUT);
  pinMode(ledPinSari,OUTPUT);
  
}
 
void loop()
{
digitalWrite(ledPin,HIGH);
delay(4000);
digitalWrite(ledPinSari,HIGH);
delay(1750);
digitalWrite(ledPinSari,LOW);
digitalWrite(ledPin,LOW);
digitalWrite(ledPinYesil,HIGH);
delay(4000);
digitalWrite(ledPinYesil,LOW);
delay(1000);
digitalWrite(ledPinYesil,HIGH);
delay(1000);
digitalWrite(ledPinYesil,LOW);
delay(1000);
digitalWrite(ledPinYesil,HIGH);
delay(1000);
digitalWrite(ledPinYesil,LOW);
digitalWrite(ledPinSari,HIGH);
digitalWrite(ledPin,LOW);
delay(2000);
digitalWrite(ledPinSari,LOW);



}
 
