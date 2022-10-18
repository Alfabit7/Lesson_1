// Вычисляется сумма всех нечетных натуральных чисел от n1 до n2
// (n1 и n2 вводятся с клавиатуры, цикл for).
Console.Clear();

Console.Write("Enter number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int count = 0;
int result = 0;

Console.Write("Enter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"You enter {number1}, {number2} ");

if (number1 % 2 == 0)
{
    count = number1 + 1;
    while (count <= number2)
    {
        result = result + count;
        count += 2;
    }
    Console.WriteLine($"Summ = {result}");
}

else
{
    count = number1;
    while (count <= number2)
    {
        result = result + count;
        count += 2;
    }
    Console.WriteLine($"Summ = {result}");
}
