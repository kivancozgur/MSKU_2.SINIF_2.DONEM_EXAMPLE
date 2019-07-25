int ledPin=3;
int trig=4;
int echo=5;
double sure;
double toplamYol;
double aradakiMesafe;
void setup() {
  pinMode(ledPin, OUTPUT);
  pinMode(trig, OUTPUT); 
  pinMode(echo, INPUT); 
  Serial.begin(9600);
}

void loop() {
  digitalWrite(trig, HIGH);
  digitalWrite(trig, LOW);
   sure = pulseIn(echo, HIGH); 
  toplamYol = sure*0.034;  
   aradakiMesafe = toplamYol / 2;
  Serial.println(aradakiMesafe);
  delay(100);
  if(aradakiMesafe<15){
      digitalWrite(ledPin, HIGH);  
      delay(100);                       
      digitalWrite(ledPin, LOW);    
      delay(100);
      if(aradakiMesafe<10){
         digitalWrite(ledPin, HIGH);  
         delay(50);                       
         digitalWrite(ledPin, LOW);    
         delay(50);
         if(aradakiMesafe<5){
            digitalWrite(ledPin, HIGH);  
            delay(1000);                       
         }
         
      }
  }
}
