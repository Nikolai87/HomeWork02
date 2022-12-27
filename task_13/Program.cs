// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что цифры нет.

Console.WriteLine("введите число: ");
int n = int.Parse(Console.ReadLine()!);
int y = 0;
if (n >= 100)
{
    while (n > 999)
    {
        n = n / 10;
    }

    Console.WriteLine($"третья цифра вашего числа {y = n % 10}");    
}
else Console.WriteLine("третьей цифры нет");
