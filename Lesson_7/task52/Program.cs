// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
// int randomRow = new Random().Next(3, 7);
// int randomColumn = new Random().Next(3, 7);
int randomRow = 5;
int randomColumn = 5;
double[,] newArr = CreateRandomArray(randomRow, randomColumn);
PrintArray(newArr);
int n = newArr.GetLength(1);
double[] arithmeticMean = new double[n];
Console.WriteLine($"newArr.GetLength(1) = {newArr.GetLength(1)}");
Console.WriteLine($"newArr.GetLength(0) = {newArr.GetLength(0)}");
double[] result = SearchArithmeticMean(newArr);




//Функиця создания массива рандомных размеров  от randomRow строк  до randomColumn столбцов
double[,] CreateRandomArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
//  Функция вывода в консоль массива 
void PrintArray(double[,] array)
{
    Console.Clear();
    // Console.Write("------------");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

// Функция суммирует все элементы входящего массива по столбцу, и эту сумму записывает как элемент нового возвращаемого массива
double[] SearchArithmeticMean(double[,] array)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Console.Write($" sum = sum {sum} + array {array[j, i]}= {(sum = sum + array[j, i])}");
            sum = sum + Convert.ToInt32(array[j, i]);
            // Console.Write($"{array.GetLength(0)}");
        }
        arithmeticMean[i] = sum;
        sum = 0;
        // Console.WriteLine($"{array.GetLength(1)}");
    }
    return arithmeticMean;
}


Console.Write($"Среднее арифмитическое чисел в столбце равно: ");
foreach (int i in result)
{

    Console.Write($"{(i / 2)}; ");
}


