// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("введите число от 1 до 7: ");
int i = int.Parse(Console.ReadLine());

switch (i)
{
    case 1: Console.WriteLine("это понедельник"); break;
    case 2: Console.WriteLine("это вторник"); break;
    case 3: Console.WriteLine("это среда"); break;
    case 4: Console.WriteLine("это четверг"); break;  
    case 5: Console.WriteLine("это пятница"); break;
    case 6: Console.WriteLine("это суббота"); break;
    case 7: Console.WriteLine("это воскреснье"); break;
    default: Console.WriteLine("это не день недели"); break;
}

if (i == 6 || i == 7)
{
    Console.WriteLine("выходной день");
}

if (i >=1 && i <= 5)
{
    Console.WriteLine("рабочий день");
}
