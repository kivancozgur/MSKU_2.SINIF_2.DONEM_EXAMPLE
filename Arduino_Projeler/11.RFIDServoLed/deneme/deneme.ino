#include <SPI.h>                          //SPI kütüphanemizi tanımlıyoruz.
#include <MFRC522.h>                      //MFRC522 kütüphanemizi tanımlıyoruz.
#include <Servo.h>                        //Servo kütüphanemizi tanımlıyoruz.
#define buzzerPin 3

int rpin = 7;  // kırmızı
int gpin = 6; // yeşil
int bpin = 5; // mavi
int RST_PIN = 9;                          //RC522 modülü reset pinini tanımlıyoruz.
int SS_PIN = 10;                          //RC522 modülü chip select pinini tanımlıyoruz.
int servoPin = 8;                         //Servo motor pinini tanımlıyoruz.
Servo motor;                              //Servo motor için değişken oluşturuyoruz.
MFRC522 rfid(SS_PIN, RST_PIN);            //RC522 modülü ayarlarını yapıyoruz.
byte ID[4] = {147, 217, 73, 26};          //Yetkili kart ID'sini tanımlıyoruz. 

void setup() { 
  motor.attach(servoPin);                 //Servo motor pinini motor değişkeni ile ilişkilendiriyoruz.
  Serial.begin(9600);                     //Seri haberleşmeyi başlatıyoruz.
  SPI.begin();                            //SPI iletişimini başlatıyoruz.
  rfid.PCD_Init();                        //RC522 modülünü başlatıyoruz.
  pinMode(rpin,OUTPUT);
  pinMode(gpin,OUTPUT);
  pinMode(bpin,OUTPUT);
  pinMode(buzzerPin, OUTPUT);

}

void loop() {
  mavi();
  digitalWrite(buzzerPin, LOW);
        motor.write(0);                   //Servo motoru 0 dereceye getiriyoruz.
  if (!rfid.PICC_IsNewCardPresent())    //Yeni kartın okunmasını bekliyoruz.
    return;

  if (! rfid.PICC_ReadCardSerial())      //Kart okunmadığı zaman bekliyoruz.
    return;

  if (rfid.uid.uidByte[0] == ID[0] &&     //Okunan kart ID'si ile ID değişkenini karşılaştırıyoruz.
    rfid.uid.uidByte[1] == ID[1] && 
    rfid.uid.uidByte[2] == ID[2] && 
    rfid.uid.uidByte[3] == ID[3] ) {
        kapiac();
        kapikapat();

    }
    else{                                 //Yetkisiz girişte içerideki komutlar çalıştırılır.
      kirmizi();
      digitalWrite(buzzerPin, LOW);
      digitalWrite(buzzerPin, HIGH);
      delay(100);
      digitalWrite(buzzerPin, LOW);
      delay(100);
      digitalWrite(buzzerPin, HIGH);
      delay(100);
      digitalWrite(buzzerPin, LOW);
      delay(100);
      digitalWrite(buzzerPin, HIGH);
      delay(100);
      digitalWrite(buzzerPin, LOW);
      delay(1000);
      Serial.println("Yetkisiz Kart");
      ekranaYazdir();
       mavi();
      }
    rfid.PICC_HaltA();
  }

  void ekranaYazdir(){
    Serial.print("ID Numarasi: ");
    for(int sayac = 0; sayac < 4; sayac++){
      Serial.print(rfid.uid.uidByte[sayac]);
      Serial.print(" ");
    }
    Serial.println("");
  }
  void yesil(){
     digitalWrite(rpin,HIGH);
    digitalWrite(gpin,0);
    digitalWrite(bpin,HIGH);
  }
  void kirmizi(){
     digitalWrite(rpin,0);
    digitalWrite(gpin,HIGH);
    digitalWrite(bpin,HIGH);
  }
  void mavi(){
    digitalWrite(rpin,HIGH);
    digitalWrite(gpin,HIGH);
    digitalWrite(bpin,0);
  }
  void kapiac(){
     yesil();
     
     digitalWrite(buzzerPin, HIGH);
     delay(100);
     digitalWrite(buzzerPin, LOW);
     Serial.println("Kapi acildi");
     ekranaYazdir();
                 
     motor.write(90);
     delay(2000);             
    }
    void kapikapat(){
      motor.write(0);
      digitalWrite(buzzerPin, LOW);
    }
