/*Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


// int rows = new Random().Next(3, 8);
// int columns = new Random().Next(3, 8);

int rows = 3;
int columns = 3;

// int[,] myArray = CreateArray(rows, columns);
int[,] myArray = CreateSpiralArr(rows, columns);
Console.WriteLine();
PrintArray(myArray);



// Функция создает двумерный массив 
// int[,] CreateArray(int rows, int columns)
// {
//     int[,] arr = new int[rows, columns];
//     int m = 1;
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             arr[i, j] = m;
//             m++;
//         }

//     }
//     return arr;
// }

// Функция печатает массив
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine($" ");
    }
}






//0 //0 //0 //0 //0 
//0   0   0   0 //0
//0   0   0   0 //0
//0   0   0   0 //0
//0 //0 //0 //0 //0 

// iStart = 0;
// iEnd = rows кол-во строк ;
// jStart = 0;
// jEnd = rows кол-во строк ;


// ПЕРВЫЙ ЦИКЛ
// Первая строка слева направо   i=iStart=0 J=jStart=0;  const i; for (j=jStart=0; J++)  //rows = 4 columns= 4  после цикла уменьшаем  rows=iEnd на -1  и увеличиваем  на 1 iStart= 1

// Последняя колонка сверху вниз  J=jEnd=columns=4;   for( i=iStart=1 i<rows i++ )  //rows = 3  columns= 4  iStart=1; jStart=0   после цикла уменьшаем  columns на -1 и

// Последняя строка справа налево i=iEnd=rows=3 for (J=jEnd=columns=3 j<=0 --j до ноля); //rows = 3  columns= 3   после цикла уменьшаем  rows на -1  rows будет равен 2

// Первая колонка снизу вверх  j=iStart0; for (i=iEnd=rows=2  i<=0  i-- до ноля)  //rows = 2  columns= 3 , после цикла уменьшаем  columns на -1 columns будет равен 2  и увеличиваем  на 1 jStart= 1

// ВТОРОЙ ЦИКЛ

// Первая строка слева направо   i=iStart=1 J=jStart=1;





int[,] CreateSpiralArr(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    int iStart = 0;
    int jStart = 0;
    int iEnd = arr.GetLength(0);
    int jEnd = arr.GetLength(1);
    int count = 1;


    while (iEnd != 1 && jEnd != 1)

    {
        // Первая строка слева направо 
        for (int j = jStart; j < arr.GetLength(1); j++)
        {
            arr[iStart, j] = count;
            count++;
        }
        jStart = 0;
        iEnd -= 1;
        // jEnd -= 1;
        iStart += 1; //вызываем в цикле т.к. ругается что в цикле не определено значением 

        // Последняя колонка сверху вниз
        for (int i = iStart; i < jEnd; i++)
        {
            arr[i, jEnd - 1] = count;
            count++;
        }


        jEnd -= 1;
        // iEnd -= 1;

        // Последняя строка справа налево
        for (int j = jEnd; j > 0; j--)
        {
            arr[iEnd, j - 1] = count;
            count++;
        }

        iEnd -= 1;
        jEnd -= 1;


        for (int i = iEnd; i > 0; i--)
        {
            arr[i, jStart] = count;
            count++;
        }
        // iEnd -= 1;
        // jStart += 1;

    }

    arr[iEnd, jEnd] = count;
    return arr;
}





















/*
// идем слева на право до конца J, потом спускаемся вниз идем до конца i потом идем справа налева до начала J , идем снизу вверх до начала i

// если конец строки т.е.  j ==  arr.GetLength(1)  то нужно заполнять массив,
// вниз т.е нужно увеличивать i при сохранении j равной  последней строке получается нужно вызывать функции поочередно 

if (int j == arr.GetLength(1)){


}



// Функция заполняет слева направо
int i = coutStart;//coutStart-счетчик колонок сначала
for (int j = 0; j < arr.GetLength(1); j++)
{
    {
        arr[i, j] = value;

    }

}


// если о последняя колонка нужно вызвать новую функцию сверху вниз заполнить
if (j == arr.GetLength(1))
{
    //вызываем функцию которая заполняет сверху вниз 
}



//функция которая заполняет сверху вниз 
j == arr.GetLength(1); // равно последней колонке 
for (int i = 0; i < arr.GetLength(0); i++)
{
    arr[i; j ]= value;

}

// если о последняя строка нужно вызвать новую функцию справа налево 
if (i == arr.GetLength(0))
{
    //вызываем функцию которая заполняет справа налево  
}

//Функция которая заполняет справо налево 
i = arr.GetLength(0);
for (j; j < arr.GetLength(1); j++)
{
    arr[i; j ]= value;
}

// если о последняя строка нужно вызвать новую функцию справа налево 
if (j == coutStart;  //coutStart-счетчик колонок сначала )
{
    //вызываем функцию которая заполняет снизу вверх  
}



//функция которая заполняет сверху вниз 






int[,] CreateArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j <= columns; j++)
        {

            if (j == columns)
            {
                functionTopToDown(j);
            }
            arr[i, j] = new Random(0).Next(0, 10);


        }

    }
    return arr;
}
*/


/*
int[,] arr = new int[rows, columns];
int y = 0;
int x = 0;
int yCount = 0;
int xCount = 0;

//Слева направо заполняем массив 
for (x = 0; x <= columns; x++)
{
    //Если последняя колонка равна количеству колонок 
    // то перезаписываем номер строки с которой нужно будет вызыввать следующий цикл : yCount+1, 
    // уменьшаем количество оставшихся строк на -1: rows-=1;
    // вызываем функцию funToptoDown заполнения сверху вниз
    // в нее передаем номер колонки: x на которой остановились и с которой следует начать заполнение следующим циклом
    if (x == columns)
    {
        yCount += 1;
        rows -= 1;
        funToptoDown(x);
    }

    // заполняем массив по колонкам 
    arr[y, x] = new Random(0).Next(0, 10);
}

// Функция заполнения сверху вниз принимает аргумет с какой строки нужно начать заполнение сверху вниз 
funToptoDown(int x)
{
    for (i = yCount; i <= rows; i++)
    {
        if (y == rows)
        {
            columns -= 1;
            funRigthToLeft(y); // Функ. заполнения справа влево, принимает номер строки на которой остановились
        }
        arr[yCount, x] = new Random(0).Next(0, 10);
    }
}

// Функция заполнения сверху вниз принимает аргумет с какой строки нужно начать заполнение справа влево 
funRigthToLeft(y);
{
    for (i = yCount; i <= rows; i++)
    {
        if (y == rows)
        {
            columns -= 1;
            funRigthToLeft(y); // Функ. заполнения справа влево, принимает номер строки на которой остановились
        }
        arr[yCount, x] = new Random(0).Next(0, 10);
    }
}

*/




