// // // Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// // // A (3,6); B (2,1) -> 5,09 
// // // A (7,-5); B (1,-1) -> 7,21
// // // d = √(xb - xa)2 + (yb - ya)2

Console.Clear();
double Distance(int x1, int y1, int x2, int y2)
{
    double s = 0;
    s = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return s;
}
Console.WriteLine("enter coordinate");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, x2, y2);

Console.WriteLine(Math.Round(distance, 3));

// { Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5)} формула для ДЗ
