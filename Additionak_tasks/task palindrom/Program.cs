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
    if (firstNumber == lastNumber)
    {
        Console.WriteLine("this a number is a palindrom");

    }

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