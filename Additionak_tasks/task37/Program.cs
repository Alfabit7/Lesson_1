// 37. Задача. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
int[] myArr = CreateRandomArray(7, 1, 10);
void ShowArray(int[] array)

{
    int multiplication = 1;
    int end = array.Length - 1;
    Console.WriteLine("Массив: " + String.Join(", ", myArr));
    for (int i = 0; i < array.Length / 2; i++)
    {
        multiplication = array[i] * array[end];
        Console.Write(multiplication + " ");
        end -= 1;
    }

    if (array.Length % 2 != 0)
    {
        Console.WriteLine(array[array.Length / 2] + " ");
    }
}

ShowArray(myArr);