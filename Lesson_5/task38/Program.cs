
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76   

Console.Clear();
// Функция создает массив элементов 
Console.WriteLine("Введите количество элемнтов массива");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
double[] createArray(int size)
{
    double[] array = new double[size];


    for (int i = 0; i < array.Length; i++)
    {
        double randomElementArr = Math.Round((new Random().NextDouble() * 10), 2);
        array[i] = randomElementArr;
    }
    return array;
}

double[] myArr = createArray(num);

Console.WriteLine("Source array: " + String.Join(" - ", myArr));

double findMinMaxElements(double[] arr)
{
    int i = 0;
    double min = arr[i];
    double max = arr[i];
    double result = 0;

    while (i < arr.Length)
        if (arr[i] > max)
        {
            max = arr[i];
            i++;
        }
        else
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            else { i++; }
        }

    result = Math.Round(max - min, 2);
    Console.WriteLine();
    Console.WriteLine($"max= {max} - min= {min} = {result}");
    return result;

}


// Функция ищет мин макс число в массиве
double result = findMinMaxElements(myArr);
