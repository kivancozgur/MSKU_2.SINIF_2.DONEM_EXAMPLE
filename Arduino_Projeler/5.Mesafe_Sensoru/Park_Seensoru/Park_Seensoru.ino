int ledPink=13;
int ledPins=12;
int ledPiny=11;
int buzzer=10;
int trig=2;
int echo=3;
float sure;
float mesafe;
  void setup() {
    pinMode(ledPink, OUTPUT);
    pinMode(ledPins, OUTPUT);
    pinMode(ledPiny, OUTPUT);
    pinMode(buzzer, OUTPUT);
    pinMode(trig, OUTPUT);
    pinMode(echo, INPUT);
    Serial.begin(9600);
  }
  
  void loop() {
    digitalWrite(trig,HIGH);
    delayMicroseconds(1000);
    digitalWrite(trig,LOW);
    sure=pulseIn(echo,HIGH);
    mesafe=(sure/2)/29;
    Serial.println(mesafe);
    
    if(mesafe<=10){
    digitalWrite(ledPink, HIGH);   
    digitalWrite(buzzer, HIGH);
    delay(100);
    digitalWrite(ledPink, LOW);   
    digitalWrite(buzzer, LOW);
    delay(90);
    }
    else if(mesafe<=10){
    digitalWrite(ledPink, HIGH);   
    digitalWrite(buzzer, HIGH);
    delay(100);
    digitalWrite(ledPink, LOW);   
    digitalWrite(buzzer, LOW);
    delay(90);
    }
    else if(mesafe<=20){
    digitalWrite(ledPins, HIGH);  
    digitalWrite(buzzer, HIGH);
    delay(200);
    digitalWrite(ledPins, LOW);   
    digitalWrite(buzzer, LOW);
    delay(150);
    } 
    else if(mesafe<=30){
    digitalWrite(ledPiny, HIGH);  
    digitalWrite(buzzer, HIGH);
    delay(500);
    digitalWrite(ledPiny, LOW);   
    digitalWrite(buzzer, LOW);
    delay(450);
    }
    else{
    digitalWrite(ledPiny, LOW);   
    digitalWrite(ledPins, LOW); 
    digitalWrite(ledPink, LOW); 
    }
    }
