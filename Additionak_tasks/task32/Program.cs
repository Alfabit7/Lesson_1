
// https://docs.google.com/presentation/d/1sHUBZz8JlljyscU3YPZDqrFOwH0dAaeQCF3zFxf47eM/edit#slide=id.g11654c8e27b_0_23

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
int[] myArr = CreateRandomArray(10, -10, 10);
void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 5)
        {
            Console.WriteLine("5 есть в массиве");
        }

    }
    Console.WriteLine();
}

ShowArray(myArr);

