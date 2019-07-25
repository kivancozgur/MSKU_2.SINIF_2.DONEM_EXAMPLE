void setup() {
  Serial.begin(9600);
  pinMode(2,INPUT);
}

void loop() {
  if(digitalRead(2)==true) Serial.println("1");
  delay(100);
}
