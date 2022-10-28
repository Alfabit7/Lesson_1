// 1. Нарисовать поле 
// 2. Каждое клетку поля связать с переменной 
// При нажатии кнопки выдавать либо крсетик либо нолик в зависмости от того кто ходит 
// 3. Чередовать ход игрока 

// int i = 0;
// int keyPress = 0;

// Клетки поля - Field Cells
// int field0 = 0;
// int field1 = 1;
// int field2 = 2;
// int field3 = 3;
// int field4 = 4;
// int field5 = 5;
// int field6 = 6;
// int field7 = 7;
// int field8 = 8;
// int[] arrField = { field0:0, 1, 2, 3, 4, 5, 6, 7, 8 };

// for (i = 0; i < 3; i++)
// {

//     Console.Write("|");

//     for (int j = 0; j < 3; j++)
//     {
//         if (i == 0)
//         {
//             Console.Write($" {keyPress} ");
//             Console.Write("|");
//             keyPress++;
//             // if (keyPress == 0) { field0 = keyPress; }
//             // if (keyPress == 1) { field0 = keyPress; }
//         }

//         if (i == 1)
//         {
//             Console.Write($" {keyPress} ");
//             Console.Write("|");
//             keyPress++;
//         }

//         if (i == 2)
//         {
//             Console.Write($" {keyPress} ");
//             Console.Write("|");
//             keyPress++;
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine(keyPress);


// var num1 = new[] { 1, 2, 3 };
// var num2 = new[] { 4, 5, 6 };
// var num3 = new[] { 7, 8, 9 };
// string x = "x"; // крестики
// string o = "o"; // нолики
// Запрашиваем ввод числа


// Вариант 2
Console.Clear();
// Массив из которого состоит игровое поле
string[][] numbers = new string[3][];
numbers[0] = new string[] { "1", "2", "3" };
numbers[1] = new string[] { "4", "5", "6" };
numbers[2] = new string[] { "7", "8", "9" };
int moveCounter = 0; //Счетчик ходов не больше 9 
int changeCellI = 0; int changeCellJ = 0; // параметры функции которая заполняет клетку ноиком или крестиком 
// Функция которая отрисовывает поле после хода игрока
peplayRenderField();


Console.Write("Введите число клетки: ");

int userDigit = Convert.ToInt32(Console.ReadLine());
while (userDigit < 1 || userDigit > 9)

{
    Console.Write("Введите число клетки: ");
    userDigit = Convert.ToInt32(Console.ReadLine());
}
//  сделать защиту на  ввод числа поставить  от 1 до 9

// функция отрисовывает поле 
void renderFileld(string[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write($"{currentArray[i]} \t");
    }
    Console.WriteLine();
    Console.WriteLine();
}


void peplayRenderField()
{
    for (int i = 0; i < numbers.Length; i++)
    {
        renderFileld(numbers[i]);
    }
}

// функция проверяет занята клетка или нет если занята предлагает сделать другой ход
void checkingNextMove()
{
    peplayRenderField();
    Console.Write("Это клетка уже занята, повторите ввод: ");
    userDigit = Convert.ToInt32(Console.ReadLine());

}

// Функция заполняет  клетку крестиком  или ноликом 

void changeCell(int changeCellI, int changeCellJ)
{
    numbers[changeCellI][changeCellJ] = "x";
    peplayRenderField();
    Console.Write("Ходит следующий игрок: ");
    userDigit = Convert.ToInt32(Console.ReadLine());
    moveCounter++;
}

while (moveCounter < 10)
{


    switch (userDigit)
    {
        case 1:
            changeCellI = 0; changeCellJ = 0;
            Console.WriteLine("You enter 1");
            if (numbers[changeCellI][changeCellJ] == "x" || numbers[changeCellI][changeCellJ] == "o")
            {
                checkingNextMove();
            }
            else
            {

                Console.Clear();
                changeCell(changeCellI, changeCellJ);
            }
            break;
        case 2:
            changeCellI = 0; changeCellJ = 1;
            if (numbers[changeCellI][changeCellJ] == "x" || numbers[changeCellI][changeCellJ] == "o")
            {
                checkingNextMove();
            }
            else
            {
                Console.Clear();

                changeCell(changeCellI, changeCellJ);
            }
            break;
        case 3:
            changeCellI = 0; changeCellJ = 2;
            if (numbers[changeCellI][changeCellJ] == "x" || numbers[changeCellI][changeCellJ] == "o")
            {
                checkingNextMove();
            }
            else
            {
                changeCell(changeCellI, changeCellJ);
            }
            break;
        case 4:
            changeCellI = 1; changeCellJ = 0;
            Console.WriteLine($"{numbers[changeCellI][changeCellJ]}");
            if (numbers[changeCellI][changeCellJ] == "x" || numbers[changeCellI][changeCellJ] == "o")
            {
                checkingNextMove();
            }
            else
            {
                changeCell(changeCellI, changeCellJ);
            }
            break;
        case 5:
            changeCellI = 1;
            changeCellJ = 1;
            if (numbers[changeCellI][changeCellJ] == "x" || numbers[changeCellI][changeCellJ] == "o")
            {
                checkingNextMove();
            }
            else
            {
                changeCell(changeCellI, changeCellJ);
            }
            break;
        case 6:
            changeCellI = 1;
            changeCellJ = 2;

            if (numbers[changeCellI][changeCellJ] == "x" || numbers[changeCellI][changeCellJ] == "o")
            {
                checkingNextMove();
            }
            else
            {
                changeCell(changeCellI, changeCellJ);
            }
            break;
        case 7:
            changeCellI = 2; changeCellJ = 0;
            if (numbers[changeCellI][changeCellJ] == "x" || numbers[changeCellI][changeCellJ] == "o")
            {
                checkingNextMove();
            }
            else
            {
                changeCell(changeCellI, changeCellJ);
            }
            break;
        case 8:
            changeCellI = 2;
            changeCellJ = 1;
            if (numbers[changeCellI][changeCellJ] == "x" || numbers[changeCellI][changeCellJ] == "o")
            {
                checkingNextMove();
            }
            else
            {
                changeCell(changeCellI, changeCellJ);
            }
            break;
        case 9:
            changeCellI = 2;
            changeCellJ = 2;
            if (numbers[changeCellI][changeCellJ] == "x" || numbers[changeCellI][changeCellJ] == "o")
            {
                checkingNextMove();
            }
            else
            {
                changeCell(changeCellI, changeCellJ);
            }
            break;
    }
}
/*
   if (userDigit == 1)
    {
        Console.WriteLine("You enter 1");
        numbers[0][0] = "x";
        peplayRenderField();
    }
    if (userDigit == 2)
    {
        Console.WriteLine("You enter 1");
        numbers[0][1] = "x";
        peplayRenderField();
    }

    */




// renderFileld(num1);

// void renderFileld(int x)
// {
//     Console.Clear();
//     foreach (int[] row in numbers)
//     {
//         foreach (int number in row)
//         {
//             Console.Write($"{number} \t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] filed = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 9, 9 } };
// foreach (int i in filed)
// {
//     Console.WriteLine(i);
// }

// int [,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

// int rows = numbers.GetUpperBound(0) + 1;    // количество строк
// Console.WriteLine($"rows = {rows}");
// int columns = numbers.Length / rows;        // количество столбцов
// Console.WriteLine($"columns = {columns}");  // или так 
//                                             // int columns = numbers.GetUpperBound(1) + 1;

// void renderFileld(int x)
// {
//     Console.Clear();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write($"{numbers[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// Запрашиваем ввод числа

// Console.Write("Введите число: ");
// //  защиту на  ввод числа поставить  
// int player1 = Convert.ToInt32(Console.ReadLine());
// renderFileld(player1);
// switch (player1)
// {
//     case 1:
//         Console.WriteLine("You enter 1");
//     numbers[0, 0] = "x";
//     break;
//     case 2:
//         Console.WriteLine("You enter 2");
//     break;
//     case 3:
//         Console.WriteLine("You enter 3");
//     break;
//     case 4:
//         Console.WriteLine("You enter 3");
//     break;
//     case 5:
//         Console.WriteLine("You enter 5");
//     break;
//     case 6:
//         Console.WriteLine("You enter 6");
//     break;
//     case 7:
//         Console.WriteLine("You enter 7");
//     break;
//     case 8:
//         Console.WriteLine("You enter 8");
//     break;
//     case 9:
//         Console.WriteLine("You enter 9");
//     break;
// }

// void cellEntry (player1){
// }




// int player21 = Convert.ToInt32(Console.ReadLine());

// if (player1 == )

// Console.WriteLine($" Выводим второй элемент массива {numbers[0][2]}");
// Console.WriteLine($" Выводим пятый элемент массива {numbers[1][1]}");




/* Вариант 1
// Клетки поля - Field Cells
int field0 = 0;
int field1 = 1;
int field2 = 2;
int field3 = 3;
int field4 = 4;
int field5 = 5;
int field6 = 6;
int field7 = 7;
int field8 = 8;

string cellField = "*";
for (int i = 0; i < 3; i++)
{

    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{cellField} \t");
    }
    Console.WriteLine();
    Console.WriteLine();
}

Console.Write("Введите число: ");
int userDigit = Convert.ToInt32(Console.ReadLine());
//  защиту на  ввод числа поставить  
switch (userDigit)
{
    case 1:
        Console.WriteLine("You enter 1");
        break;
    case 2:
        Console.WriteLine("You enter 2");
        break;
    case 3:
        Console.WriteLine("You enter 3");
        break;
    case 4:
        Console.WriteLine("You enter 3");
        break;
    case 5:
        Console.WriteLine("You enter 5");
        break;
    case 6:
        Console.WriteLine("You enter 6");
        break;
    case 7:
        Console.WriteLine("You enter 7");
        break;
    case 8:
        Console.WriteLine("You enter 8");
        break;
    case 9:
        Console.WriteLine("You enter 9");
        break;
}*/
