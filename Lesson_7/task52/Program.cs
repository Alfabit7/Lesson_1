Console.Clear();
/*
Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
// Создаем рандомные значения строк и столбцов для последующего создания двумерного массива 
int randomRow = new Random().Next(2, 5);
int randomColumn = new Random().Next(2, 5);

// Функция создает рандомный двумерный массив newArr из randomRow строк  и randomColumn столбцов
double[,] newArr = CreateRandomArray(randomRow, randomColumn);

// Функция принимает двумерный массив и выводит его на экран
PrintArray(newArr);

// Функция суммирует все элементы входящего массива по каждому столбцу и находит среднее арифметическое столбца, это ср. арифм.  записывает как элемент нового возвращаемого массива
double[] result = SearchArithmeticMean(newArr);

Console.Write($"Среднее арифмитическое чисел в столбце равно: ");

// Проходим циклом по массиву полученному от функции  SearchArithmeticMean и вводим значение на экран
foreach (double i in result)
{
    Console.Write($"{(i),5:f2}; ");
}


//Функция создания массива рандомных размеров  от randomRow строк  до randomColumn столбцов
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
//  Функция вывода массива в консоль  
void PrintArray(double[,] array)
{
    Console.Clear();
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

// Функция суммирует все элементы входящего массива по каждому столбцу и находит среднее арифметическое столбца, это  ср. арифм.  записывает как элемент нового возвращаемого массива
double[] SearchArithmeticMean(double[,] array)
{
    double sum = 0;
    double[] arithmeticMean = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = (sum + Convert.ToInt32(array[j, i]));
        }
        sum = sum / array.GetLength(0);
        arithmeticMean[i] = sum;
        sum = 0;
    }
    return arithmeticMean;
}