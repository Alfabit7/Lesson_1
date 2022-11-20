// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. // Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4        // 17->такого числа в массиве нет

Console.Clear();
int findRow;
int findColumn;
int randomRow;
int randomColumn;
// Повтор запроса поиска элемента, используем функцию если  элемента не существует в массиве
void RepeatRequest()
{
    Console.Write("Введите номер строки в которой ищем элемент: ");
    findRow = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    Console.Write("Введите номер столбца в котором ищем элемент: ");
    findColumn = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    randomRow = new Random().Next(2, 10);
    randomColumn = new Random().Next(3, 10);
}
// Вызываем запрос поиска  первый раз
RepeatRequest();

int[,] CreateRandomArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
int[,] newArr = CreateRandomArray(randomRow, randomColumn);

//Печать массива
PrintArray(newArr);
void PrintArray(int[,] array)
{
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
// поиск значение элеменат в массиве
void FindElementtoArr(int row, int column)
{
    row -= 1; column -= 1;// чтобы пользователь вводил числа начиная с 1
    if (row <= newArr.GetLength(0) && column <= newArr.GetLength(1))
    {
        Color("white");
        Console.Write($"Элемент в строке {row} и столбце {column} равен: {newArr[row, column]} ");

    }
    else
    {

        Console.Write($"Поиск не соответствует размерам массива задайте числа больше либо меньше");
        Console.WriteLine();
        RepeatRequest();
        newArr = CreateRandomArray(randomRow, randomColumn);
        PrintArray(newArr);
        FindElementtoArr(findRow, findColumn);
    }
}

FindElementtoArr(findRow, findColumn);

void Color(string color)
{
    if (color == "green") Console.ForegroundColor = ConsoleColor.Green;
    else if (color == "red") Console.ForegroundColor = ConsoleColor.Red;
    else if (color == "yellow") Console.ForegroundColor = ConsoleColor.Yellow;
    else if (color == "cyan") Console.ForegroundColor = ConsoleColor.Cyan;
    else if (color == "magenta") Console.ForegroundColor = ConsoleColor.Magenta;
    else if (color == "black") Console.ForegroundColor = ConsoleColor.Black;
    else if (color == "white") Console.ForegroundColor = ConsoleColor.White;
    else if (color == "gray") Console.ForegroundColor = ConsoleColor.Gray;
}

