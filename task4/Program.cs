// Task №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Decision
Console.Clear();
Console.Write("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine("Max number " + number1);
    }
    else
        Console.WriteLine("Max number " + number3);
}
else
if (number2 > number3)
{
    Console.WriteLine("Max number " + number2);
}
else Console.WriteLine("Max number " + number3);