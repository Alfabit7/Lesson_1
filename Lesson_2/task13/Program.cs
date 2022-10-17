// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

int number = new Random().Next(1, 1000);

if (number > 99)
{
    Console.WriteLine(number % 10);
}
else Console.WriteLine("number is not three digits");