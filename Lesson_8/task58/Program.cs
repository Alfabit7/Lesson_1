/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

// int rows = new Random().Next(2, 8);
// int columns = new Random().Next(3, 9);

// int[,] myArray = CreateArray(rows, columns);
// int[,] myArray2 = CreateArray(rows, columns);
int[,] myArray = CreateArray(4, 5);
int[,] myArray2 = CreateArray(5, 2);
Console.WriteLine();
Console.WriteLine("Matrix A");
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine("Matrix B");
PrintArray(myArray2);
Console.WriteLine();
bool printOnNotPrint = false;
int[,] newArray = MultipliesMatrices(myArray, myArray2);

if (printOnNotPrint)
{
    Console.WriteLine("Matrix C");
    PrintArray(newArray);
}


// Функция печатает массив
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine($" ");
    }
}

// Функция создает двумерный массив 
int[,] CreateArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = new Random().Next(1, 4);
        }
    }
    return arr;
}

//Функция перемножает две двумерные матрицы и вовдит результат если их можно перемножить
int[,] MultipliesMatrices(int[,] arr, int[,] arr1)
{
    int[,] result = new int[arr.GetLength(0), arr1.GetLength(1)];
    if (arr.GetLength(1) != arr1.GetLength(0))
    {
        Console.WriteLine("Перемножение невозможно количество столбцов первой матрицы не совпадает с количеcтвом строк второй матрицы ");
    }
    else
    {
        printOnNotPrint = true;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    result[i, j] += arr[i, k] * arr1[k, j];
                }
            }
        }
    }

    return result;
}

