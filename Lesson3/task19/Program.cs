// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Clear();
// Console.WriteLine("enter a five digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// while (number < 9999 || number > 99999)
// {
//     Console.WriteLine("You not enter five digit");
//     Console.WriteLine("enter a five digit number: ");
//     number = Convert.ToInt32(Console.ReadLine());
// }

// // Сравниваем первое число с последним и  второе число с предпоследним 

// if (number / 10000 == number % 10 && number / 1000 / 10 % 10 == number % 10)
// {

//     Console.WriteLine("this is number a palindrom");
// }

// else
// {
//     Console.WriteLine("this number is not a palindrom ");


// }

// Решения для любого вводимого числа 

Console.Clear();
Console.WriteLine("enter number: ");
int number = Convert.ToInt32(Console.ReadLine());


