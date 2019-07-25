#include <SPI.h>                          //SPI kütüphanemizi tanımlıyoruz.
#include <MFRC522.h>                      //MFRC522 kütüphanemizi tanımlıyoruz.
#include <Servo.h>                        //Servo kütüphanemizi tanımlıyoruz.
#include <LiquidCrystal.h>
//SDA=10
//SCK=13
//MOS1=11
//M1S1=12
//RST=9
int RST_PIN = 9;                          //RC522 modülü reset pinini tanımlıyoruz.
int SS_PIN = 10;                          //RC522 modülü chip select pinini tanımlıyoruz.
int servoPin = 8;                         //Servo motor pinini tanımlıyoruz.
LiquidCrystal lcd(7, 6, 5, 4, 3, 2);
//VSS=GND
//VDD=5V
//V0=GND PWM ORTASI
//RS=7
//RW=GND
//E=6
//D4=5
//D5=4
//D6=3
//D7=2
//A=3.3V
//K=GND
Servo motor;                              //Servo motor için değişken oluşturuyoruz.
MFRC522 rfid(SS_PIN, RST_PIN);            //RC522 modülü ayarlarını yapıyoruz.
byte ID[4] =  {147, 217, 73, 26};         //Yetkili kart ID'sini tanımlıyoruz. 
int rpin = 1;  // kırmızı
int gpin = 0; // yeşil
void setup() {
 pinMode(rpin,OUTPUT);
  pinMode(gpin,OUTPUT);
  motor.attach(servoPin);                 //Servo motor pinini motor değişkeni ile ilişkilendiriyoruz.
  Serial.begin(9600);                     //Seri haberleşmeyi başlatıyoruz.
  SPI.begin();                            //SPI iletişimini başlatıyoruz.
  rfid.PCD_Init();                        //RC522 modülünü başlatıyoruz.
   lcd.begin(16, 2);
   lcd.clear();
}
 
void loop() {
  lcd.clear();
  lcd.setCursor(4, 0);
  lcd.print("KART");
  lcd.setCursor(5, 1);
  lcd.print("OKUTUNUZ");
  if ( ! rfid.PICC_IsNewCardPresent())    //Yeni kartın okunmasını bekliyoruz.
    return;

  if ( ! rfid.PICC_ReadCardSerial())      //Kart okunmadığı zaman bekliyoruz.
    return;

  if (rfid.uid.uidByte[0] == ID[0] &&     //Okunan kart ID'si ile ID değişkenini karşılaştırıyoruz.
    rfid.uid.uidByte[1] == ID[1] && 
    rfid.uid.uidByte[2] == ID[2] && 
    rfid.uid.uidByte[3] == ID[3] ) {
      lcd.clear();
        yesil();
        lcd.setCursor(4, 0);
        lcd.print("KAPI");
        lcd.setCursor(5, 1);
        lcd.print("ACILDI");
        Serial.println("Kapi acildi");
        ekranaYazdir();
        motor.write(180);                 //Servo motoru 180 dereceye getiriyoruz.
        delay(3000);
        motor.write(0);                   //Servo motoru 0 dereceye getiriyoruz.
        delay(1000);
    }
    else{                                 //Yetkisiz girişte içerideki komutlar çalıştırılır.
      kirmizi();
        lcd.clear();
        lcd.setCursor(4, 0);
        lcd.print("YETKISIZ");
        lcd.setCursor(5, 1);
        lcd.print("KART");
      Serial.println("Yetkisiz Kart");
      ekranaYazdir();
      delay(1000);
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
  }
  void kirmizi(){
     digitalWrite(rpin,HIGH);
    digitalWrite(gpin,HIGH);
  }
