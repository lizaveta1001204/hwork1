﻿﻿Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());
int max = 0;
if (num1 > num2)
{
    max = num1;
    if (max > num3)
    {
        Console.WriteLine($"Максимальное число {max}");
    }
    else
    {
        max = num3;
        Console.WriteLine($"Максимальное число {max}");
    }
}
else
{
    max = num2;
    if (max > num3)
    {
     Console.WriteLine($"Максимальное число {max}");
    }
    else
    {
        max = num3; 
        Console.WriteLine($"Максимальное число {max}");
    }
}