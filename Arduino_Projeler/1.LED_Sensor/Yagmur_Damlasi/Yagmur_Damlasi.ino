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
delay(30);
digitalWrite(ledPin,HIGH);
delay(350);
digitalWrite(ledPinSari,HIGH);
digitalWrite(ledPin,LOW);
digitalWrite(ledPinYesil,LOW);
delay(350);
digitalWrite(ledPinSari,LOW);
digitalWrite(ledPin,LOW);
digitalWrite(ledPinYesil,HIGH);
delay(350);
digitalWrite(ledPinSari,LOW);
digitalWrite(ledPin,LOW);
digitalWrite(ledPinYesil,LOW);

}
 
