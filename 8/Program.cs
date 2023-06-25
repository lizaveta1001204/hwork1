Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine()!);
int n = 2;
while (n <= num)
    {
        Console.Write($"{n}, ");
        n+=2;
    }