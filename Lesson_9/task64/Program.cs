/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();
int num = Convert.ToInt32(Console.ReadLine());

//Функция выводит натуральные числа в промежутке от N до 1. 
void PrintNumber(int number)
{
    Console.Write(number + " ");
    if (number > 1) { PrintNumber(number - 1); }
}
PrintNumber(num);
