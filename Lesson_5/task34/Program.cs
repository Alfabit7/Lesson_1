// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.  [345, 897, 568, 234] -> 2


Console.Clear();
// Функция создает массив элементов 
int[] createArray(int size, int start, int end)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        int randomElementArr = new Random().Next(start, end);
        array[i] = randomElementArr;
    }
    return array;
}

int[] myArr = createArray(20, 100, 1000);

// Функция считает  кол-во четных элементов в массиве 
int showQuantityEvenElemnet(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Source array: " + String.Join(" ", myArr));
int result = showQuantityEvenElemnet(myArr);
Console.WriteLine("Quantity Event Elements: " + result);
