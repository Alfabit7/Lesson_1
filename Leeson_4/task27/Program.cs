// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
int sum = 0;
Console.Write("Введите число: ");
string num = Console.ReadLine();
for (int i = 0; i < num.Length; i++)
{
    string str;
    str = Convert.ToString(num[i]);
    int number = Convert.ToInt32(str);
    sum += number;
}
Console.WriteLine("sum= " + sum);