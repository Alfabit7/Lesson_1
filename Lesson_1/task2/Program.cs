// Task №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Decision
Console.Clear();
Console.WriteLine("enter first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You enter first number = " + number1);

Console.WriteLine("Enter second number");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You enter second number = " + number2);

if (number1 != number2)
{
    if (number1 > number2)
    {
        Console.WriteLine("The number " + number1 + " is greater than the number " + number2);
    }

    else Console.WriteLine("The number " + number2 + " is greater than the number " + number1);

}
else Console.WriteLine("the numbers are equal");