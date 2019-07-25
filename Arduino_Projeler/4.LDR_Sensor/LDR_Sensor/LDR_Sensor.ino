int ledPin = 7;
int LDRPin = A0;
void setup()
{ 
  pinMode(ledPin, OUTPUT);
  Serial.begin(9600);
}
 
void loop()
{
  delay(100);
   int isik_degeri = analogRead(LDRPin);
    Serial.println(isik_degeri); 
     if(isik_degeri<70)
     {
       digitalWrite(ledPin, HIGH);
      
     }
     else
     {
       digitalWrite(ledPin, LOW);
       
     }
  
}
