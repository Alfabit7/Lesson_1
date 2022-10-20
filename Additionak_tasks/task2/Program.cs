// Вычисляется сумма квадратов n натуральных чисел, начиная с k
// (вводятся k и n, цикл for).

Console.Clear();

int count = 0;
int result = 0;

Console.Write("Enter number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You enter {number1}, {number2} ");

if (number2 < 1)
{
    Console.WriteLine($"enter {number2}> 1");
}

count = number1;
Console.WriteLine($"Summ = {count}");

// while (count <= number2) ;
// {
//     // result = count * count;
//     count++;
//     Console.WriteLine($"Summ = {count}");
// }

while (count <= number2)
{
    result = count * count;
    Console.WriteLine(result);
    count++;

}



