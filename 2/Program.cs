﻿﻿Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
if(number1 > number2){
    Console.WriteLine(number1);
}
else
    if(number1<number2){
         Console.WriteLine(number2);
  } 
   else
   if(number1==number2){
    Console.WriteLine("Оба числа равны");
    } 