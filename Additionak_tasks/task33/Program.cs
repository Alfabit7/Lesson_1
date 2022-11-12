//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

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
    Console.Write("Введите число, которое ищете в массиве: ");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            Console.WriteLine($" {num} есть в массиве");
            return;
        }

    }
    Console.WriteLine($" {num} нет в массиве");
}

ShowArray(myArr);
