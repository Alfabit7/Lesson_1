// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
double result;

Console.WriteLine("enter the coordinates x1 y1 z1: ");
double userX1 = Convert.ToInt32(Console.ReadLine());
double userY1 = Convert.ToInt32(Console.ReadLine());
double userZ1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the coordinates x2 y2 z2: ");
double userX2 = Convert.ToInt32(Console.ReadLine());
double userY2 = Convert.ToInt32(Console.ReadLine());
double userZ2 = Convert.ToInt32(Console.ReadLine());

// Function 
double FindDistanceBetweenCoordinates(double x1, double y1, double z1, double x2, double y2, double z2)
{
    result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return result;
}

FindDistanceBetweenCoordinates(userX1, userY1, userZ1, userX2, userY2, userZ2);
result = Math.Round(result, 2);
Console.WriteLine($"Result = {result}");