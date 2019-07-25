/*
* Lezzetli Robot Tarifleri
* VİDEO >>> https://lezzetlirobottarifleri.com/2x16-lcd-ekran-ve-arduino-1/
*/
#include <LiquidCrystal.h>

LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
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

void setup() {  
    lcd.begin(16, 2);
    lcd.clear();
}

void loop() {
  lcd.clear();
  lcd.setCursor(4, 0);
  lcd.print("KART");
  lcd.setCursor(5, 1);
  lcd.print("OKUTUNUZ");
  delay(1000);
  
}
