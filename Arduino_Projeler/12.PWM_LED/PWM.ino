int kirmizi = 3; 
int yesil = 10;
int mavi = 6;
int pot=A0;
int potdeger;


void setup()
{
  pinMode(kirmizi, OUTPUT);
  pinMode(yesil, OUTPUT);
  pinMode(mavi, OUTPUT);
  pinMode(pot, INPUT);
  
  Serial.begin(9600);
}

void loop()
{

  Serial.println(potdeger);
  
  potdeger= analogRead(pot)/4;
  for(int i=0;i<768;i++){
      if(potdeger==i )  {
      analogWrite(kirmizi,i); 
      analogWrite(yesil,i); 
      analogWrite(mavi,0);  
      Serial.println("i degeri="+i);
      delay(500);
    }
    else if(potdeger<i){
      analogWrite(kirmizi,0); 
      analogWrite(yesil,i); 
      analogWrite(mavi,i);  
      Serial.println("i degeri="+i);
      delay(500);
    }
     else if(potdeger>i){
      analogWrite(kirmizi,i); 
      analogWrite(yesil,0); 
      analogWrite(mavi,i);  
      Serial.println("i degeri="+(i));
      delay(500);
    }
  }
}
