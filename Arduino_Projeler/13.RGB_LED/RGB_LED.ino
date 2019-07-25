int rpin = 7;  // kırmızı
int gpin = 6; // yeşil
int bpin = 5; // mavi
void setup()
{
  pinMode(rpin,OUTPUT);
  pinMode(gpin,OUTPUT);
  pinMode(bpin,OUTPUT);
}
void loop()                     
{
 kirmizi();
 delay(100);
 mavi();
 delay(100);
 yesil();
 delay(100);
 
}

void yesil(){
   digitalWrite(rpin,HIGH);
  digitalWrite(gpin,0);
  digitalWrite(bpin,HIGH);
}
void mavi(){
   digitalWrite(rpin,0);
  digitalWrite(gpin,HIGH);
  digitalWrite(bpin,HIGH);
}
void kirmizi(){
     digitalWrite(rpin,HIGH);
  digitalWrite(gpin,HIGH);
  digitalWrite(bpin,0);
}
