// Функция проверяет что вводится именно число а не буквы и число в диапазоне от 1 до 9
/*
string userDigit = string.Empty;
int number = 0;
Console.Clear();
Console.WriteLine("enter number");
userDigit = Console.ReadLine();
// while (int.TryParse(number, out int userDigit) || userDigit < 9)
while (!int.TryParse(userDigit, out number) | number > 9 | number < 1)
{
    Console.WriteLine("enter the number again");
    userDigit = Console.ReadLine();
}*/
//=============================== не трогать проверка ввода числа от 1 до 9 

// Console.Clear();
// int[] array = new int[8];  
// for (int i = 0; i < 8; i++)
// {
//    Console.WriteLine("Введите 8 чисел через Enter: ");
//    Console.Write($"{i + 1}-й элемент массива: ");
//    array[i] = int.Parse(Console.ReadLine());
//    Console.Clear();
// }
// Console.WriteLine($"[{String.Join(", ", array)}]");


// Console.WriteLine("Введите числа через запятую: ");
// string input = Console.ReadLine();
// int count = 1;
// for (int i = 0; i < input.Length; i++)
// {
//     if (input[i] == ',') count++;
// }
// int[] result = new int[count];
// int j = 0;
// for (int i = 0; i < input.Length; i++)
// {
//     if (input[i] == ',') j++;
//     else if (result[j] == 0) result[j] = int.Parse(input[i].ToString());
//     else result[j] = result[j] * 10 + int.Parse(input[i].ToString());
// }

// int[] array = { 1, 23, 345, 4567, 5678, 678, 78, 9 };
// Console.WriteLine($"{String.Join(",-", array)}");

// С семинара 
// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {   
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// Функция показать массив
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_pos = 0;
// int sum_neg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//         sum_pos += myArray[i];
//     else
//         sum_neg += myArray[i];
// }

// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");





