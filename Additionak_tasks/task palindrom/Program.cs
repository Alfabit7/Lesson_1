Console.Clear();
Console.WriteLine("enter a number > 9 but < 100000000000: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int count = 0;
int number = userNumber;
int firstNumber = 0;
int lastNumber = 0;

// Check that the number is not less than 9
while (userNumber < 10)
{
    Console.WriteLine("enter a number > 9 but < 100000000000: ");
    userNumber = Convert.ToInt32(Console.ReadLine());
}
// We find how many digits the userentered
number = userNumber;

if (userNumber < 99)
{
    count = 0;
    firstNumber = userNumber / 10;
    lastNumber = userNumber % 10;
    if (firstNumber == lastNumber)
    {
        Console.WriteLine("this a number is a palindrom");

    }
    else { Console.WriteLine("this number is not a palindrom"); }
}
else
{

    // Считаем сколько цифр ввел ползователь
    while (number != 0)
    {
        number = number / 10;
        count++;
    }

    Console.WriteLine($"You have entered an {count} digit number, степень числа {Math.Pow(10, count)}");
    firstNumber = userNumber / Convert.ToInt32(Math.Pow(10, count - 1));
    lastNumber = userNumber % 10;


    if (firstNumber == lastNumber)
    {


        while (count > 1)
        {
            count -= 1;
            Console.WriteLine($"Первое число {firstNumber}");
            Console.WriteLine($"последнее число {lastNumber}");
            Console.WriteLine($"Делитель {Convert.ToInt32(Math.Pow(10, count - 1))}");
            Console.WriteLine($"count = {count}");


            Console.WriteLine($"usernNumber= {userNumber}");
            firstNumber = userNumber / Convert.ToInt32(Math.Pow(10, count - 1)) % 10;
            lastNumber = userNumber / 10 % 10;
            Console.WriteLine($"Делитель {Convert.ToInt32(Math.Pow(10, count - 1))}");
            if (firstNumber == lastNumber)
            {
                count -= 1;
                Console.WriteLine($"Первое число {firstNumber}");
                Console.WriteLine($"последнее число {lastNumber}");
                Console.WriteLine($"Делитель {Convert.ToInt32(Math.Pow(10, count - 1))}");
                Console.WriteLine($"count = {count}");


                Console.WriteLine($"usernNumber= {userNumber}");
                firstNumber = userNumber / Convert.ToInt32(Math.Pow(10, count - 1)) % 10;
                lastNumber = userNumber / 10 % 10;
                Console.WriteLine($"Делитель {Convert.ToInt32(Math.Pow(10, count - 1))}");
            }
            Console.WriteLine("exit to if2");

        }
        Console.WriteLine("this is a number is palindrom");
    }


    else
    {
        Console.WriteLine("this is a number is not palindrom");

    }
}


// ==================================
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
// // Решения для любого вводимого числа 

// Console.Clear();
// Console.WriteLine("enter a number > 9 but < 100000000000: ");
// int userNumber = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// int number = userNumber;
// int firstNumber = 0;
// int lastNumber = 0;

// // Check that the number is not less than 9
// while (userNumber < 10)
// {
//     Console.WriteLine("enter a number > 9 but < 100000000000: ");
//     userNumber = Convert.ToInt32(Console.ReadLine());
// }
// // We find how many digits the userentered
// if (9 < userNumber && userNumber < 99)
// {
//     while (number != 0)
//     {
//         number = number / 10;
//         count++;
//     }
//     Console.WriteLine($"You have entered an {count} digit number, степень числа {Math.Pow(10, count)}");
//     firstNumber = userNumber / Convert.ToInt32(Math.Pow(10, count));
//     lastNumber = userNumber % 10;

//     Console.WriteLine($"Первое число {firstNumber}");
//     Console.WriteLine($"последнее число {lastNumber}");

// }
// else
// {

//     count = 1;
//     while (number != 0)
//     {
//         number = number / 10;
//         count++;
//     }

//     firstNumber = userNumber / Convert.ToInt32(Math.Pow(10, count));
//     lastNumber = userNumber % 10;

//     Console.WriteLine($"Первое число {firstNumber}");
//     Console.WriteLine($"последнее число {lastNumber}");
// }



Console.Clear();
Console.WriteLine("enter a number > 9 but < 100000000000: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int count = 0; //  displays the digit capacity of the entered number  
int number = userNumber; //need to calculate the capasity of the entered number
int firstNumber = 0;  // The first digit of userNumber 
int lastNumber = 0; // Last digit of userNumber 

// Check that the number is not less than 9
while (userNumber < 10)
{
    Console.WriteLine("enter a number > 9 but < 100000000000: ");
    userNumber = Convert.ToInt32(Console.ReadLine());
}

number = userNumber;
//Checked a two digit number for a palindrom
if (userNumber < 99)
{
    count = 0;
    // find first and last digit
    firstNumber = userNumber / 10;
    lastNumber = userNumber % 10;
    if (firstNumber == lastNumber)
    {
        Console.WriteLine("this  number is a palindrom");
    }
    else { Console.WriteLine("this number is not a palindrom"); }

}
else
// If the number is greater than two digits 
{
    // We find how many digits the userentered
    while (number != 0)
    {
        number = number / 10;
        count++;
    }

    Console.WriteLine($"You have entered an {count} digit number, degree of userNumber {Math.Pow(10, count)}");
    firstNumber = userNumber / Convert.ToInt32(Math.Pow(10, count - 1));
    lastNumber = userNumber % 10;
    Console.WriteLine($" useerNumber = {userNumber}");




    if (firstNumber == lastNumber)
    {
        while (count > 1)
        {
            count -= 1;
            firstNumber = userNumber / Convert.ToInt32(Math.Pow(10, count - 1)) % 10;
            lastNumber = userNumber / 10 % 10;
            if (firstNumber == lastNumber)
            {
                count -= 1;
                firstNumber = userNumber / Convert.ToInt32(Math.Pow(10, count - 1)) % 10;
                lastNumber = userNumber / 10 % 10;
            }
        }

        Console.WriteLine("this is a number is palindrom");
    }


    else
    {
        Console.WriteLine("this is a number is not palindrom");

    }
}