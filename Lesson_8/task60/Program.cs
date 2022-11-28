/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/



int y = new Random().Next(3, 10);
int x = new Random().Next(3, 10);
int z = new Random().Next(3, 10);

// Проверяем что диапазон трехмерного массива не больше 99 
while (x * y * z > 99)
{
    y = new Random().Next(3, 10);
    x = new Random().Next(3, 10);
    z = new Random().Next(3, 10);
}
// Создаем трехмерный рандомный массив 
int[,,] myArray = CreateThreeArray(x, y, z);
// Выводим массив на экран
PrintThreeArray(myArray);


// Функция генерация трехмерного рандомного массива 
int[,,] CreateThreeArray(int y, int x, int z)
{
    int[,,] arr = new int[y, x, z];
    // m двузначные значения, которыми будет заполнятся массив от 10 до 99 
    int m = 10;
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            for (int k = 0; k < z; k++)
            {
                arr[i, j, k] = m;
                m++;
            }
        }
    }
    return arr;
}

// Функция выводит на экран трехмерный массив 
int[,,] PrintThreeArray(int[,,] arr)

{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($" {arr[i, j, k],5:f2} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    return arr;
}
