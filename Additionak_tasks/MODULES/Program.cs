// Функция проверяет что вводится именно число, а не буквы и число в диапазоне от 1 до 9
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

// Функция создает массив 
/*int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
*/

// Функция отображает по-элментно одномерный массив
/*void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/