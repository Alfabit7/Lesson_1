// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Dicision
Console.Clear();

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 999)
{
    Console.WriteLine($"You enter {number}");
    Console.WriteLine((number / 10) % 10);
}
else Console.WriteLine("Please replay enter");