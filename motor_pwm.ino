#include <LiquidCrystal.h>
#define Botao1 14
#define Botao2 15
#define Botao3 16
#define Botao4 17
#define Botao5 18
#define Botao6 19
#define Botao7 20
#define Botao8 21
#define L1 7
#define L2 6
#define L3 5
#define L4 4
#define L6 3
#define L5 2
#define ON 9
#define OFF 8
#define MOTOR1 13
#define MOTOR2 12
#define MOTOR3 11
#define MOTOR4 10
bool sist = true;
LiquidCrystal lcd(23, 25, 27, 29, 31, 33); 
void config_placa()
{
pinMode(Botao1,INPUT_PULLUP);//
pinMode(Botao2,INPUT_PULLUP);//
pinMode(Botao3,INPUT_PULLUP);//
pinMode(Botao4,INPUT_PULLUP);//
pinMode(Botao5,INPUT_PULLUP);//
pinMode(Botao6,INPUT_PULLUP);//
pinMode(Botao7,INPUT_PULLUP);//
pinMode(Botao8,INPUT_PULLUP);//
pinMode(ON,INPUT_PULLUP);//
pinMode(OFF,INPUT_PULLUP);/

pinMode(MOTOR1,OUTPUT);//SAÍDA
pinMode(MOTOR2,OUTPUT);//SAÍDA
pinMode(MOTOR3,OUTPUT);//SAÍDA
pinMode(MOTOR4,OUTPUT);//SAÍDA
pinMode(L1,OUTPUT);//SAÍDA
pinMode(L2,OUTPUT);//SAÍDA
pinMode(L3,OUTPUT);//SAÍDA
pinMode(L4,OUTPUT);//SAÍDA
pinMode(L5,OUTPUT);//SAÍDA
pinMode(L6,OUTPUT);//SAÍDA

 digitalWrite(MOTOR1,0);//DESLIGADO
digitalWrite(MOTOR2,0);//DESLIGADO
digitalWrite(MOTOR3,0);//DESLIGADO
digitalWrite(MOTOR4,0);//DESLIGADO
digitalWrite(L1,0);//DESLIGADO 
digitalWrite(L2,0);//DESLIGADO
digitalWrite(L3,0);//DESLIGADO
digitalWrite(L4,0);//DESLIGADO
digitalWrite(L5,0);//DESLIGADO
digitalWrite(L6,1);//LIGADO
 lcd.begin(20,4);//DEFININDO O TAMANHO DO LCD
lcd.setCursor(0,0);
 lcd.setCursor(0,0);
lcd.print("SISTEMA OFF");
lcd.setCursor(0,1);
lcd.print("M1 OFF M2 OFF");
lcd.setCursor(0,2);
lcd.print("M3 OFF M4 OFF");
}
void controle_Motor()
{
 if(digitalRead(ON) == 0)
 {
 sist = true;
digitalWrite(L5,1);
digitalWrite(L6,0);
lcd.setCursor(0,0);
lcd.print("SISTEMA ON ");
lcd.setCursor(0,1);
lcd.print("M1 OFF M2 OFF");
lcd.setCursor(0,2);
lcd.print("M3 OFF M4 OFF");
 } 
 if(digitalRead(OFF) == 0)
 { sist =
false;
 digitalWrite(L5,0);
digitalWrite(L6,1);
 digitalWrite(MOTOR1,0);
digitalWrite(MOTOR2,0);
digitalWrite(MOTOR3,0);
digitalWrite(MOTOR4,0);
digitalWrite(L1,0);
digitalWrite(L2,0);
digitalWrite(L3,0);
digitalWrite(L4,0);
digitalWrite(L5,0);
lcd.setCursor(0,0);
lcd.print("SISTEMA OFF");
lcd.setCursor(0,1);
lcd.print("M1 OFF M2 OFF");
lcd.setCursor(0,2);
lcd.print("M3 OFF M4 OFF");
 }
if(sist == true)
 {
 if(digitalRead(Botao1) == 0)
 {
 digitalWrite(MOTOR1,1);
 digitalWrite(L1,1);
digitalWrite(L5,1);
