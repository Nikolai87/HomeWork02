// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("введите трехзначное число: ");
if (int.TryParse(Console.ReadLine(), out int n))
{
        if (n >= 100 && n < 1000)
        {
             int y = (n / 10) % 10;
            Console.WriteLine($"вторая цифра вашего числа {y}");
        }
    else
    {
        System.Console.WriteLine("вы ввели не трехзначное число");
    }
}
else
{
    System.Console.WriteLine("вы ввели не число");
}