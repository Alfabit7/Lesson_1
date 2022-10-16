//Task №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа 2 до N

// Decision
Console.Clear();
Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;

while (i <= number)
{
    Console.WriteLine(i);
    i = i + 2;
}