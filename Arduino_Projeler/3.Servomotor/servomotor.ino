#include <Servo.h>                        //Servo kütüphanemizi tanımlıyoruz.
int servoPin = 8;                         //Servo motor pinini tanımlıyoruz.
Servo motor;                    
  
  void setup() {
    motor.attach(servoPin);                 //Servo motor pinini motor değişkeni ile ilişkilendiriyoruz.
  }
  
  void loop() {

motor.write(0);
delay(1000);
motor.write(180);
delay(1000);
motor.write(90);
delay(1000);
  }
