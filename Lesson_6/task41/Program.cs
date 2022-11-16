// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2    // 1, -7, 567, 89, 223-> 4
Console.Clear();
Console.WriteLine();
Console.WriteLine("please enter the  numbers separated by a space");
string[] userNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int result = 0;

int QuantityMoreZero(string[] arr)
{
    foreach (string i in userNumbers)
    {
        Console.Write(i + " ");
        int num = Convert.ToInt32(i);
        if (num > 0)
        {
            result++;
        }
    }
    return result;
}
QuantityMoreZero(userNumbers);
Console.WriteLine("Колличество числе больше ноля равно: " + result);

