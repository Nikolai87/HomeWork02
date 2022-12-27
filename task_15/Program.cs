// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("введите число от 1 до 7: ");
if (int.TryParse(Console.ReadLine(), out int n))
{
        if (n >= 1 && n <= 5)
        {
            Console.WriteLine("рабочий день");
        }
        if (n == 6 || n == 7)
        {
            Console.WriteLine("выходной день");
        }
        if (n > 7) 
        {
            Console.WriteLine("вы ввели неверное число");
        }
}
else
{
    Console.WriteLine("вы ввели не число");
}