//Task №6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Decision
Console.Clear();
Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());
if (0 == number % 2)
{
    Console.WriteLine("The entered number is event");
}
else Console.WriteLine("The entered number is odd");