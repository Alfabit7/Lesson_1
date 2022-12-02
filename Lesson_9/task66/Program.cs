/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15-> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

int numM;
int numN;
int sum = 0;

RequestUserNumber();
int result = sumMandN(numM);
Console.Write(result);


void RequestUserNumber()
{
    Console.Write("Введите число M: ");
    numM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N, которое больше, предыдущего числа M: ");
    numN = Convert.ToInt32(Console.ReadLine());
    if (numM > numN) { RequestUserNumber(); }
}

int sumMandN(int M)
{
    if (M <= numN)
    {
        sum += M;
        sumMandN(M + 1);
    }
    return sum;
}


