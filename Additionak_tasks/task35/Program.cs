// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
int[] myArr = CreateRandomArray(10, -100, 100);
void ShowArray(int[] array)

{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] > 10 && array[i] < 100)
        {
            count++;
        }
    }
    Console.WriteLine($" {count} кол-во чисел от 10 до 99 ");
}

ShowArray(myArr);
