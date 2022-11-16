// Задача 43:
//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями // y = k1 * x + b1, y = k2 * x + b2;  
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5,  b1 = 2, k2 = 9 b2 = 4,  -> (-0,5; -0,5)

Console.Clear();
Console.Write("Enter K1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter K2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
double x; // хранит выычисленное значение X
double y; // хранит выычисленное значение Y


if (k1 != k2)
{
    x = (b2 - b1) / (k1 - k2);
    y = x * k1 + b1;
    Console.WriteLine($"Координаты пересечния прямых: {x} : {y}");
}
else
{
    Console.Write(" прямые параллельны");
}
