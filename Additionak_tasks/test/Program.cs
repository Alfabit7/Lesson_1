
// Поле для тетриса 
/*
string[,] playField = new string[,]
{
    { "1", "2", "3", "4", "5", "6","7"},
    { "1", "2", "3", "4", "5", "6","7"},
    { "1", "2", "3", "4", "5", "6","7"},
    { "1", "2", "3", "4", "5", "6","7"},
    { "1", "2", "3", "4", "5", "6","7"},
    { "1", "2", "3", "4", "5", "6","7"},
    { "1", "2", "3", "4", "5", "6","7"},
    { "1", "2", "3", "4", "5", "6","7"}
};

void ShowArray(string[,] arr)
{
    Console.WriteLine("_____________________________");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("|   |   |   |   |   |   |   |");
        Console.WriteLine("|   |   |   |   |   |   |   |");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("|_" + arr[i, j] + "_");
        }
        Console.WriteLine("|");
    }
}

*/

/*
// Массив поле для игры в тетрис
string[,] playField = new string[,]
{
    // { "                           |"},
    // { "                           |"},
    // { "                           |"},
    // { "                           |"},
    // { "                           |"},
    // { "                           |"},
    // { "                           |"},
    // { "                           |"},
    // { "                           |"},
    // { "                           |"},
    // { "                           |"},
    { "111111111111111111111111111|"},
    { "111111111111111111111111111|"},
    { "111111111111111111111111111|"},
    { "111111111111111111111111111|"},
    { "111111111111111111111111111|"},
    { "111111111111111111111111111|"},
    { "111111111111111111111111111|"},

};
// Отрисовывает массив поле для игры в тетрис
void ShowArray(string[,] arr)
{
    Console.Clear();
    Console.WriteLine("         TETRIS GAME");
    // Console.WriteLine("_____________________________");
    Console.WriteLine("11111111111111111111111111111");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("|                           |");
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            Console.Write("|" + arr[i, j]);
        }
        Console.WriteLine();
    }
}

ShowArray(playField);
// Console.WriteLine("|___________________________|");
Console.WriteLine("|111111111111111111111111111|");
Console.WriteLine();

// Функция закрашивает клетку 

void FieldColoring(int coordinateX, int coordinateY)
{

    for (int i = 0; i < playField.GetLength(0); i++)
    {
        for (int j = 0; j < playField.GetLength(1); j++)
        {
            if (playField[coordinateX, coordinateY] == String.Empty)
            {
                Console.WriteLine(playField[i, j] = "+");
                // Console.WriteLine("+");

            };
        }
    }
}


FieldColoring(10, 10);

*/


//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
/*
Clear();
Write("Введите элементы массива через пробел: ");
string elements = ReadLine();
int[] baseArray = GetArrayFromString(elements);

WriteLine(String.Join(" ", ResultArray(baseArray)));

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int[] ResultArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
    return result;
}
*/



// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// CreateRandomArray(7, 1, 10);
// Console.WriteLine(String.Join(" ", CreateRandomArray(7, 1, 10)));

// С семинара
/*
//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] reversArray = ReversArray2(array);
Console.WriteLine(String.Join(" ", reversArray));

ReversArray1(array);
Console.WriteLine(String.Join(" ", array));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReversArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}

int[] ReversArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];

    }
    return result;
}
*/



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45-> 101101
// 3-> 11
// 2-> 10

/*С семинар
// Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (max - min);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f5} ");
        }
        Console.WriteLine();
    }
}


*/

// Console.Clear();
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = i + j;
//         }
//     }
//     return result;
// }


// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);


// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// void CheckArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//     }
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(array);
// CheckArray(array);
// Console.WriteLine();
// PrintArray(array);





// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);

// int sum;
// int[,] GetArray(int m, int n, int min, int max)
// {
//     sum = 0;
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//             if (i == j)
//             {
//                 sum = sum + result[i, j];
//             }

//         }

//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(array);

// Console.WriteLine();

// Console.WriteLine(sum);
// https://docs.google.com/presentation/d/1LiZVEdhHYOEm_xpFU7XIWJl8eLskHXC1vSQjw9fz90E/edit#slide=id.g10f07d28dee_0_221

// https://drive.google.com/file/d/1AMYk45d4dpJCqHscJ6doUHjG5EqTRWB4/view


// Задача 52 
// +++++++++++++++++++++++++++++++++++++++++++++++




Console.Clear();
// int randomRow = 7;
// int randomColumn = 7;

int randomRow = new Random().Next(3, 10);
int randomColumn = new Random().Next(2, 10);

double[,] newArr = CreateRandomArray(randomRow, randomColumn);
PrintArray(newArr);
double[] result = SearchArithmeticMean(newArr);
double n;

Console.Write($"Среднее арифмитическое чисел в столбце равно: ");

foreach (double i in result)
{
    Console.Write($"{(i / result.Length),3:f2}; ");
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

// Функция суммирует все элементы входящего массива по столбцу, и эту сумму записывает как элемент нового возвращаемого массива
double[] SearchArithmeticMean(double[,] array)
{
    double sum = 0;
    double[] arithmeticMean = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + Convert.ToInt32(array[j, i]);
        }
        arithmeticMean[i] = sum;
        sum = 0;
    }
    return arithmeticMean;
}


