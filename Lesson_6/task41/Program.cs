// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2    // 1, -7, 567, 89, 223-> 4

Console.Clear();
Console.WriteLine();
Console.WriteLine("please enter the  numbers separated by a space");
string[] userNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int result = 0;
int checkedNum;
int[] newArr;
// Функция проверки что пользователь вводит число 
checkNumber(userNumbers);

int[] checkNumber(string[] arr)
{
    newArr = new int[userNumbers.Length];
    for (int i = 0; i < userNumbers.Length; i++)// перебираем строковый массив 
    {
        if (!int.TryParse(userNumbers[i], out checkedNum))
        {
            Console.WriteLine("please enter the  numbers separated by a space");
            checkNumber(userNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));// вызываем рекурсию
        }
        else
        {
            Console.Clear();
            newArr[i] = Convert.ToInt32(userNumbers[i]);
        }

    }
    return newArr;
}

// Функция подсчета чисел больше ноля
int QuantityMoreZero(int[] arr)
{
    Console.WriteLine("Массив введеных чисел: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            result++;
        }
        Console.Write(arr[i] + " ");
    }
    return result;
}

QuantityMoreZero(newArr);
Console.WriteLine();

Console.WriteLine("Количество чисел больше ноля равно: " + result);

