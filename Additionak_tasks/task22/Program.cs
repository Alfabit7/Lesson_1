﻿// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
void sqr(int N)
{
    if (N > 0)
    {
        int count = 1;
        while (count < N)
        {
            int result = count * count;
            Console.Write(result + ", ");
            count++;
        }
        Console.Write(N * N);
    }
    else
    {
        Console.WriteLine("Введите число больше 1");
    }
}
Console.WriteLine("enter number");
int N = Convert.ToInt32(Console.ReadLine());
sqr(N);