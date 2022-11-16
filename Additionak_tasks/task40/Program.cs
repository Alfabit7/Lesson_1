// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.Clear();
int a, b, c;
Console.WriteLine("Введите длину стороны а");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны b");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны c");
c = Convert.ToInt32(Console.ReadLine());
if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine();
    Console.WriteLine("Треугольник может существовать");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Треугольник  не может существовать");
}