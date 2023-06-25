// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int per = num % 2;

if (per == 0)
{
    Console.WriteLine($"число {num} является четным");
}
else
{
    Console.WriteLine($"число {num} не является четным");  
}