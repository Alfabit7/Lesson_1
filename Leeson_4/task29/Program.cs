// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int arrLenght = Convert.ToInt32(Console.ReadLine());
int randomNumber;
int[] arr = new int[arrLenght];
int i;

for (i = 0; i < 8; i++)
{
    randomNumber = new Random().Next(9);
    arr[i] = randomNumber;
    Console.WriteLine(arr[i]);
}

