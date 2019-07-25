#include <Servo.h>   
int veri;                           //Bluetooth üzerinden okuduğumuz değişken.
int kirmiziPin = 9;                 //RGB Ledin kırmızı bacağının takılacağı pin
int yesilPin = 10;                  //RGB Ledin yeşil bacağının takılacağı pin       
int maviPin = 11;                   //RGB Ledin mavi bacağının takılacağı pin
int buzzerPin=8;
int servoPin=2;
Servo motor;                    
void setup() {
  Serial.begin(9600);               //Seri haberleşmeyi başlatıyoruz.
  pinMode(kirmiziPin,OUTPUT);       //Kırmızı pinini OUTPUT olarak ayarlıyoruz.
  pinMode(yesilPin,OUTPUT);         //Yeşl pinini OUTPUT olarak ayarlıyoruz.
  pinMode(maviPin,OUTPUT);          //Mavi pinini OUTPUT olarak ayarlıyoruz.
  pinMode(buzzerPin,OUTPUT);
   motor.attach(servoPin);      
}
void loop() {
  if(Serial.available()>0){         //Seri haberleşmeden veri gelmesini bekliyoruz.
    veri = Serial.read();           //Seri haberleşmeden gelen veriyi okuyoruz.
  }
  if(veri == 'k'){                  //Seri haberleşmeden k harfi geldiğinde bu kısım çalışır.
  kirmizi();
  digitalWrite(buzzerPin,HIGH);
  delay(200);
  digitalWrite(buzzerPin,LOW);
  delay(200);
  motor.write(0);
  }
  else if(veri == 'y'){             //Seri haberleşmeden y harfi geldiğinde bu kısım çalışır.
  yesil();
  digitalWrite(buzzerPin,HIGH);
  delay(200);
  digitalWrite(buzzerPin,LOW);
  motor.write(0);
  
  }
  else if(veri == 'm'){             //Seri haberleşmeden m harfi geldiğinde bu kısım çalışır.
  mavi();
  digitalWrite(buzzerPin,HIGH);
  delay(200);
  digitalWrite(buzzerPin,LOW);
  motor.write(0);
  }
  else if(veri == 's'){             //Seri haberleşmeden m harfi geldiğinde bu kısım çalışır.
  mix();
  digitalWrite(buzzerPin,HIGH);
  delay(200);
  digitalWrite(buzzerPin,LOW);
  }
   else if(veri == 'a'){             //Seri haberleşmeden m harfi geldiğinde bu kısım çalışır.
  motor.write(90);
  delay(100);
  motor.write(1);
  }
  else{                             //Seri haberleşmeden tanımlanmayan veri geldiğinde bu kısım çalışır.
    digitalWrite(kirmiziPin,HIGH);
    digitalWrite(yesilPin,HIGH);
    digitalWrite(maviPin,HIGH);
  }
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
void mix(){
 digitalWrite(yesilPin,LOW);
 digitalWrite(maviPin,LOW);
 digitalWrite(kirmiziPin,LOW);  
}
