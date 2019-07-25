#include <SPI.h>
#include <MFRC522.h>
int RST_PIN = 9;
int SS_PIN = 10;     
MFRC522 rfid(SS_PIN, RST_PIN);            //RC522 modülü ayarlarını yapıyoruz.
void setup() {
  Serial.begin(9600);
  SPI.begin();
  rfid.PCD_Init();                        //RC522 modülünü başlatıyoruz.

}

void loop() {
  if(rfid.PICC_ReadCardSerial()){
    Serial.print("Kart Bulundu ID: ");
    Serial.print(rfid.uid.uidByte[0]);
    Serial.print(" ");
    Serial.print(rfid.uid.uidByte[1]);
    Serial.print(" ");
    Serial.print(rfid.uid.uidByte[2]);
    Serial.print(" ");
    Serial.print(rfid.uid.uidByte[3]);
  }
  
    rfid.PICC_HaltA();
}
