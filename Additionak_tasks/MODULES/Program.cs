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


/*
//  Функция для сортировки одномерного массива 
int[] SortArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[i])
            {
                minPosition = j;
            }

            int temp = arr[i];
            arr[i] = arr[minPosition];
            arr[minPosition] = temp;

        }
    }

    return arr;
}
*/

/*
// Функция фильтрует каждую строку двумерного  массива по убыванию
int[,] SortArray(int[,] arr)
{
    int[,] array = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int y = 0; y < arr.GetLength(0); y++)
    {
        for (int x = 0; x < arr.GetLength(1); x++)
        {
            for (int k = x + 1; k < arr.GetLength(1); k++)
            {
                if (arr[y, k] > arr[y, x])
                {

                    int temp = arr[y, x];
                    arr[y, x] = arr[y, k];
                    arr[y, k] = temp;
                }
            }
        }
    }
    return arr;
}

*/