// https://docs.google.com/presentation/d/1gPVdqYdaVFewf03dZIvgFjEU8taNOlvClStNyZg6y9w/edit#slide=id.g1174966c8de_0_0
// https://drive.google.com/file/d/1AMYk45d4dpJCqHscJ6doUHjG5EqTRWB4/view
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int rows = new Random().Next(3, 10);
int columns = new Random().Next(3, 10);
int[,] myArray = CreateArray(rows, columns);

PrintArray(myArray);
int[,] newArr = SortArray(myArray);
PrintArray(newArr);

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
// Функция фильтрует строку двумерного  массива по убыванию

int[,] SortArray(int[,] arr)
{
    int[,] array = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int y = 0; y < arr.GetLength(0); y++)
    {
        for (int x = 0; x < arr.GetLength(1); x++)
        {
            for (int k = x + 1; k < arr.GetLength(1); k++)
            {
                if (arr[y, k] > arr[y, x])
                {

                    int temp = arr[y, x];
                    arr[y, x] = arr[y, k];
                    arr[y, k] = temp;
                }
            }
        }
    }
    return arr;
}










