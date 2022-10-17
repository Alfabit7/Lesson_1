
// int[] array = new int[3];
// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int number1 = number % 10;
// int number2 = number % 100;
// Console.WriteLine(number1);
// Console.WriteLine(number2);




// if (number/10 > number%10)
// {
//     Console.WriteLine(number/10);
// }
// else
// {
//     Console.WriteLine(number%10);
// }
// int number = new Random().Next(100, 999);
// Console.WriteLine(number);

// int a1 = number / 100;
// int a2 = number % 10;
// int result = a1 * 10 + a2;
// Console.WriteLine(a1);

// Console.WriteLine(a2);
// Console.WriteLine(result);


// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно



// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine(number1 + number2);

// if (number2 % number1 == 0)
// {
//     Console.WriteLine("Числа кратные");
// }

// else Console.WriteLine(number2 % number1);
// int number1 = 13;
// int number2 = 12;

// Console.WriteLine(number1 / number2);
// Console.WriteLine(number1 % number2);



Console.Clear();
Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());


if (number2 * number2 == number1)
{
    Console.WriteLine("Число 2 явлется квадратом 1 ");
}
else Console.WriteLine("Число 2 не явлется квадратом 1 ");


if (number1 * number1 == number2)
{
    Console.WriteLine("Число 1 явлется квадратом 2 ");
}
else Console.WriteLine("Число 2 не явлется квадратом 1 ");


// // 1 Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Console.Clear();
// Console.WriteLine("Программа, которая на вход принимает два числа и проверяет, является ли число квадратом второго");
// Console.Write("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int sqrt1 = Convert.ToInt32(Math.Pow(number1, 2));
// int sqrt2 = Convert.ToInt32(Math.Pow(number2, 2));
// if (sqrt1 == number2 ^ sqrt2 == number1)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
