// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Проверяет на палиндром пятизначное число
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


// Проверяет на палиндром любое вводимое число из интервала int 
Console.Clear();
Console.WriteLine("enter a number > 9 but < 100000000000: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int count = 0; //  displays the digit capacity of the entered number  
int number = userNumber; //need to calculate the capasity of the entered number
int firstNumber = 0;  // The first digit of userNumber 
int lastNumber = 0; // Last digit of userNumber 
bool pal = true;

// Check that the number is not less than 9
while (userNumber < 10)
{
    Console.WriteLine("enter a number > 9 but < 100000000000: ");
    userNumber = Convert.ToInt32(Console.ReadLine());
}
number = userNumber;
while (number != 0)
{
    number = number / 10;
    count++;
}

Console.WriteLine($"You have entered an {count} digit number, degree of userNumber {Math.Pow(10, count)}");

firstNumber = userNumber / Convert.ToInt32(Math.Pow(10, count - 1));
lastNumber = userNumber % 10;
// Console.WriteLine($" useerNumber = {userNumber}");

if (firstNumber == lastNumber)
{
    // check  for palindrom 
    int i = 1;
    while (count > i && pal)
    {
        firstNumber = userNumber / Convert.ToInt32(Math.Pow(10, count - i)) % 10;
        lastNumber = userNumber % 10;
        pal = firstNumber == lastNumber;
        userNumber = userNumber / 10;
        i++;
        count -= 1;
    }
    Console.WriteLine(pal ? "this number is a palindrom" : "no");
}
else
{
    { Console.WriteLine("!!!this number is not a palindrom"); }
}
