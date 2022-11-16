
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



int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
CreateRandomArray(7, 1, 10);
Console.WriteLine(String.Join(" ", CreateRandomArray(7, 1, 10)));

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

