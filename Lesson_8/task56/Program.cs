/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int rows = new Random().Next(3, 10);
int columns = new Random().Next(3, 10);
int[,] myArray = CreateArray(rows, columns);

PrintArray(myArray);
// int[] newArr = SumRowArray(myArray);

string result = FindMinSumElement(SumRowArray(myArray));
Console.WriteLine(result);

// Функция печататет массив
void PrintArray(int[,] arr)
{
    Console.WriteLine("--------------------------");
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
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}
// Функция суммирует каждую строку двумерного  массива, и эту сумму записывает в новый элемент одномерного массива, и этот массив возвращет 
int[] SumRowArray(int[,] arr)
{
    int[] array = new int[arr.GetLength(0)];
    for (int y = 0; y < arr.GetLength(0); y++)
    {
        int sum = 0;
        for (int x = 0; x < arr.GetLength(1); x++)
        {
            sum = sum + Convert.ToInt32(arr[y, x]);
            array[y] = sum;
        }
    }
    return array;
}

// Функция находит наименьший элемент в одномерном массиве и возвращет его и его индекс
string FindMinSumElement(int[] arr)
{
    string message;
    int min = arr[0];
    int i = 0;
    int j = i + 1;
    for (i = 0, j = i + 1; i < arr.Length - 1; i++, j++)
    {
        if (arr[i] > arr[j])
        {
            min = arr[j];
        }
    }
    message = $"Наименьшая сумма элементов равная :{min}  находится в строке под индексом : {i} ";
    return message;
}









