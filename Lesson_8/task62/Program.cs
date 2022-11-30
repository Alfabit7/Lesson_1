/*Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);


int[,] myArray = CreateSpiralArr(rows, columns);
Console.WriteLine();
PrintArray(myArray);




// Функция печатает массив
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine($" ");
    }
}



int[,] CreateSpiralArr(int rows, int columns)
{

    int[,] arr = new int[rows, columns];
    int iStart = 0;
    int jStart = 0;
    int iEnd = arr.GetLength(0) - 1;
    int jEnd = arr.GetLength(1) - 1;
    int count = 1;
    int k = 0;


    while (k < rows)
    {

        if (rows < 0 || columns < 0) { break; }// условие выходжа из цикла while
        // Заполняем справа налево верхнюю строку
        for (int j = jStart; j < columns; j++)
        {

            if (arr[iStart, j] != 0) { continue; }
            else
            {
                arr[iStart, j] = count;
                count++;
            }
        }
        rows -= 1; iStart += 1;
        // Заполняем сверху вниз правую колонку
        for (int i = iStart; i < rows; i++)
        {

            if (arr[i, jEnd] != 0) { continue; }
            else
            {
                arr[i, jEnd] = count;
                count++;
            }
        }

        columns -= 1;
        jEnd -= 1;
        // Заполняем справа налево нижнюю строку
        for (int j = columns; j >= 0; j--)
        {
            if (arr[iEnd, j] != 0) { continue; }
            else
            {
                arr[iEnd, j] = count;
                count++;
            }
        }
        iEnd -= 1;
        // Заполняем снизу  вверх левую колонку
        for (int i = iEnd; i >= 0; i--)
        {
            if (arr[i, jStart] != 0) { continue; }
            else
            {
                arr[i, jStart] = count;
                count++;
            }
        }
        jStart += 1;
        k++;
    }
    return arr;
}








