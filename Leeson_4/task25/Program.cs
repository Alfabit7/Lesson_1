// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возвод ит число A в натуральную степень B.

Console.Clear();
int[] arr = new int[2]; // создаем пустой массив 
int multiplication = 1; // хранит результат возведения в степень
Console.Write("Введите число А: "); // Просим ввести число А
arr[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Б: "); // Просим ввести число Б
arr[01] = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < arr[01]; i++)
{
    multiplication = multiplication * arr[0];
}

Console.WriteLine($"Число {arr[0]} в степени {arr[1]} = {multiplication}");
Console.ReadKey();
