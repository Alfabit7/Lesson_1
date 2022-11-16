// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101   // 3  -> 11   // 2  -> 10

Console.Clear();
Console.Write("enter number: ");
int numUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
string result = string.Empty;
void ConversionToBinarySystem(int num)
{
    while (num > 0)
    {
        string str = Convert.ToString(num % 2);
        result = str + result;
        num /= 2;
        Console.WriteLine("NUM= " + num + "; num % 2= " + (num % 2) + "; res= " + result);

    }
    Convert.ToInt32(result);
}
ConversionToBinarySystem(numUser);
Console.WriteLine();
Console.WriteLine($"Number  {numUser}  in binary system = {result}");
Console.WriteLine();