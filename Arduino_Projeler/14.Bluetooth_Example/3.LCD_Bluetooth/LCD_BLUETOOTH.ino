#include <LiquidCrystal.h>

LiquidCrystal lcd(12, 11, 5, 4, 3, 2);

String str1="",str2="";
int cnt=0;

void setup() {  
  Serial.begin(9600);
  lcd.begin(16,2);
  lcd.clear();
}

void loop() {
  SerialEvent();
  delay(50);
}

void SerialEvent()
{
  while(Serial.available())
  {
    char inChar=(char)Serial.read(); // C#'dan oku char'a çevir ve inChar'a yaz

    cnt++; // Sayacı arttır her okuduğunda
    
    if(inChar=='*') // Bu karakteri kendimiz belirledik. LCD'yi silmek için
    {
      str1="";
      str2="";
      lcd.clear();
      lcd.print(str1);
      lcd.setCursor(0,1);
      lcd.print(str2);
    }
    if(cnt<=16){
      str1+=inChar;
      lcd.write(inChar);
    }
    else if(cnt>16 && cnt<=32){  // 16'dan büyükse 2.satıra yaz
      lcd.setCursor(0,1);
      str2+=inChar;
      lcd.write(inChar);
    }
    
   }
}
