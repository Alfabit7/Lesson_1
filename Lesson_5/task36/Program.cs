// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19    [-4, -6, 89, 6] -> 0
Console.Clear();
// Функция создает массив элементов 
int[] createArray(int size, int start, int end)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        int randomElementArr = new Random().Next(start, end);
        array[i] = randomElementArr;
    }
    return array;
}

int[] myArr = createArray(10, 0, 10);

//Функция считает сумму элементов стоящих на нечетных позициях
int sumElementsOddIndex(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

int result = sumElementsOddIndex(myArr);
Console.WriteLine("Source array: " + String.Join(" ", myArr));
Console.WriteLine("Сумма элементов стоящих на нечетных позициях 1,3,5 итд: " + result);