// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите чиcло строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чиcло столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

// double[,] userArr = new double[m, n];

// Вызываем функцию  создания массива
double[,] userArray = CreateRandomArray(m, n);
double[,] CreateRandomArray(int mRow, int nColumn)
{
    double[,] newArray = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = (new Random().NextDouble()) * new Random().Next(-10, 10);
        }
    }
    return newArray;
}


// Функция вывода массива на экран
void PrintArray(double[,] array)
{
    {
        Console.WriteLine();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{array[i, j],7:f1} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

// Вызываем функцию вывода на экран 
PrintArray(userArray);
