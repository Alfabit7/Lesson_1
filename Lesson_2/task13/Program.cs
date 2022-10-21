// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Console.Clear();

int number = new Random().Next(1, 1000);
Console.WriteLine($"The generated number is: {number}");
if (number > 99)
{
    Console.WriteLine(number % 10);
}
else Console.WriteLine("number is not three digits");


int number = new Random().Next(1, 1000);

if (number < 100 && number > 999)
{
    number = new Random().Next(1, 1000);

    Console.WriteLine("number is not three digits");
}
else

    Console.WriteLine($"The generated number is: {number}");
{
    Console.WriteLine(number % 10);

}


// // Console.WriteLine("Введите номер: ");
// // int number = Convert.ToInt32(Console.ReadLine());

// // if (Math.Abs(number) > 99)
// // {
// //     while (Math.Abs(number) > 999)
// //     {
// //         number = number / 10;
// //     }
// //     int thirdNum = number % 10;
// //     Console.WriteLine(thirdNum);
// // }
// // else
// // {
// //     Console.WriteLine("Третьей цифры нет в числе");
// // }






