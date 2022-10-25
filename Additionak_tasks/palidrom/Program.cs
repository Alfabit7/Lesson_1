int InputInt(string? value)
{
    int number = 0;
    while (!int.TryParse(value, out number))
    {
        Console.Write("Введенное выражение не является целым числом. Повторите ввод: ");
        value = Console.ReadLine();
    }
    return number;
}

int DigitCount(int number)
{
    int count = 1;
    int num = number;
    // Console.WriteLine("num равно" + num);
    while (num > 10)
    {
        num /= 10;
        count++;
    }
    // Console.WriteLine("num равно" + num + "count = " + count);
    return count;
}

bool PalindroCheck(int number)
{
    int i = 1;
    int j = Convert.ToInt32(Math.Pow(10, DigitCount(number) - 1));
    Console.WriteLine("j равно " + j);
    Console.WriteLine("i равно " + i);
    bool palindrom = true;
    while (palindrom && i < j)
    {
        int digitA = number / j % 10;
        Console.WriteLine("A равно " + digitA);
        int digitZ = number / i % 10;
        Console.WriteLine("Z равно " + digitZ);
        palindrom = digitA == digitZ;
        i *= 10;
        j /= 10;
    }
    return palindrom;
}

Console.Write("Введите число: ");
int num = InputInt(Console.ReadLine());
Console.Write(PalindroCheck(num) ? "Является полиндромом" : "Не является полиндромом");