int greenPin = 10;
int redPin = 9;
int bluePin = 11;
 
void setup() {
  Serial.begin(9600);
  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);
}
 
void loop() {
  while (Serial.available() > 0) {
 
    int red = Serial.parseInt();
 
    int green = Serial.parseInt();
 
    int blue = Serial.parseInt();
 
    if (Serial.read() == '\n') {
 
      red = 255 - constrain(red, 0, 255);
      green = 255 - constrain(green, 0, 255);
      blue = 255 - constrain(blue, 0, 255);
 
      analogWrite(redPin, red);
      analogWrite(greenPin, green);
      analogWrite(bluePin, blue);
 
      
    }
  }
}
