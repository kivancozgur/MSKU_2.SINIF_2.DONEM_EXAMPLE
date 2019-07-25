int kirmiziPin = 9;
int yesilPin = 10;  
int maviPin = 11;
int buzzerPin=8;
void setup() {
  pinMode(kirmiziPin, OUTPUT);
    pinMode(yesilPin, OUTPUT);
      pinMode(maviPin, OUTPUT);
      pinMode(buzzerPin, OUTPUT);
}

void loop() {
  mavi();
   digitalWrite(buzzerPin,HIGH);
  delay(1000);     
     digitalWrite(buzzerPin,LOW);                 
   kirmizi();
   delay(1000);
      digitalWrite(buzzerPin,HIGH);
   yesil();
  delay(1000);
}

void mavi(){
 digitalWrite(yesilPin,HIGH);
 digitalWrite(maviPin,LOW);
 digitalWrite(kirmiziPin,HIGH);
}
void kirmizi(){
 digitalWrite(yesilPin,LOW);
 digitalWrite(maviPin,HIGH);
 digitalWrite(kirmiziPin,HIGH); 
}
void yesil(){
 digitalWrite(yesilPin,HIGH);
 digitalWrite(maviPin,HIGH);
 digitalWrite(kirmiziPin,LOW);  
}
