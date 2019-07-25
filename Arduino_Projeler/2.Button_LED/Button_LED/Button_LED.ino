int ledPin = 13;
int BUTTON = 3;
int btndurum=0;
void setup()
{ 
  pinMode(ledPin,OUTPUT);
  pinMode(BUTTON,INPUT);
}
 
void loop()
{
  btndurum=digitalRead(BUTTON);
 if(btndurum==1)digitalWrite(ledPin,HIGH);
 else digitalWrite(ledPin,LOW);
}
 
