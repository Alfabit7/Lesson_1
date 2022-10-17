// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Enter the day of the week ");
int day = Convert.ToInt16(Console.ReadLine());

if (day > 0 && day <= 7)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Today is day off )");
    }
    else Console.WriteLine("Gotta go to work today");
}

else Console.WriteLine("Enter a number beetwen 1 and 7");
