// Проверяет на палиндром любое вводимое число из интервала int 
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
    Console.WriteLine("enter a number > 9 but < 1000000000: ");
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
        // check  for palindrom 
        while (count > 1)
        {
            count -= 1;
            firstNumber = userNumber / Convert.ToInt32(Math.Pow(10, count - 1)) % 10;
            lastNumber = userNumber / 10 % 10;
        }

        { Console.WriteLine("this is a number is palindrom"); }
    }
    else
    {
        Console.WriteLine("this number is not a palindrom");
    }
}