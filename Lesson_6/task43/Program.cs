// Задача 43:
//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями // y = k1 * x + b1, y = k2 * x + b2;  
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5,  b1 = 2, k2 = 9 b2 = 4,  -> (-0,5; -0,5)
/*
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

*/

using funcs;
Console.Clear();

void LinesDot(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        func.Color("magenta");
        Console.WriteLine("Прямые не пересекаются");
    }
    else
    {
        double x = Math.Round(((b2 - b1) / (k1 - k2)), 2);
        double y = Math.Round((k1 * x + b1), 2);
        func.Color("magenta");
        Console.WriteLine($"Точка пересечения двух прямых: ({x}, {y})");
    }
}

string[] coordNames = { "k1", "b1", "k2", "b2" };
double[] coords = new double[4];
string num = "";

for (int i = 0; i < coordNames.Length; i++)
{
    func.Color("green");
    Console.Write($"Введите {coordNames[i]}: ");
    num = Console.ReadLine();
    while (!func.isDouble(num))
    {
        func.Color("red");
        Console.Write("Нужно ввести число. Попробуйте снова: ");
        num = Console.ReadLine();
    }
    coords[i] = int.Parse(num);
}

LinesDot(coords[0], coords[1], coords[2], coords[3]);