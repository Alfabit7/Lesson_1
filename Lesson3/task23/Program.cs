// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("enter number: ");
int numberUser = Convert.ToInt32(Console.ReadLine());
int result = 0;

while (numberUser <= 1)
{
    Console.WriteLine("enter a number greater than one");
    numberUser = Convert.ToInt32(Console.ReadLine());
}

for (int count = 0; count <= numberUser; count++)
{
    result = Convert.ToInt32(Math.Pow(count, 3));
    Console.WriteLine($"the square  of the numberUser {count} = {result}");
}




