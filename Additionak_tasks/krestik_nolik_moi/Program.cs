// Переменные 
string userDigit = string.Empty; // переменная string которая хранит число которое вводит пользователь для проверки что это число, а не строка используется в функции checkedUserNumber
int number = 0;// number переменая int которая хранит число которое ввел пользователь   используется в функции checkedUserNumber  

int moveCounter = 1; //Счетчик ходов не больше 9 
bool whoseMove = false; // меняем значение в зависимости от того чей ход true крестики false нолики 
string crossOrToe = "o"; // переменная которая меняет клетку на нолик или крестик в зависимости от того кто ходит
string whoGoesFirst = string.Empty; // запоминает выбор фигуры игрока который будет ходить первым 
bool winOrLoss = false; // если значение true то значит кто-то победил

// Двухмерный массив для отрисовки поля
string[][] numbers = new string[3][];
numbers[0] = new string[] { "1", "2", "3" };
numbers[1] = new string[] { "4", "5", "6" };
numbers[2] = new string[] { "7", "8", "9" };

// Функция отрисовки поля
void renderFileld(string[][] numbers)
{
    for (int changeCellI = 0; changeCellI < numbers.Length; changeCellI++)
    {
        for (int changeCellJ = 0; changeCellJ < numbers[changeCellI].Length; changeCellJ++)
        {
            Console.Write($"{numbers[changeCellI][changeCellJ]} \t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

// Функция проверяет что вводится именно число а не буквы и число в диапазоне от 1 до 9
void checkedUserNumber()
{
    userDigit = Console.ReadLine();
    while (!int.TryParse(userDigit, out number) | number > 9 | number < 1)

    {
        Console.Write("Сделайте ход в поле нажав цифру от 1 до 9: ");
        userDigit = Console.ReadLine();
    }
}

// Функция проверят выиграл кто то или еще нет 
void checkedWin()
{
    if (
      //Row
      numbers[0][0] == "x" && numbers[0][1] == "x" && numbers[0][2] == "x" ||
      numbers[1][0] == "x" && numbers[1][1] == "x" && numbers[1][2] == "x" ||
      numbers[2][0] == "x" && numbers[2][1] == "x" && numbers[2][2] == "x" ||

      // Colums
      numbers[0][0] == "x" && numbers[1][0] == "x" && numbers[2][0] == "x" ||
      numbers[0][1] == "x" && numbers[1][1] == "x" && numbers[2][1] == "x" ||
      numbers[0][2] == "x" && numbers[1][2] == "x" && numbers[2][2] == "x" ||

      // dioganal
      numbers[0][0] == "x" && numbers[1][1] == "x" && numbers[2][2] == "x" ||
      numbers[0][2] == "x" && numbers[1][1] == "x" && numbers[2][0] == "x"
      )
    {
        winOrLoss = true;
    }
    if (
      numbers[0][0] == "o" && numbers[0][1] == "o" && numbers[0][2] == "o" ||
      numbers[1][0] == "o" && numbers[1][1] == "o" && numbers[1][2] == "o" ||
      numbers[2][0] == "o" && numbers[2][1] == "o" && numbers[2][2] == "o" ||

      // Colums
      numbers[0][0] == "o" && numbers[1][0] == "o" && numbers[2][0] == "o" ||
      numbers[0][1] == "o" && numbers[1][1] == "o" && numbers[2][1] == "o" ||
      numbers[0][2] == "o" && numbers[1][2] == "o" && numbers[2][2] == "o" ||

      // dioganal
      numbers[0][0] == "o" && numbers[1][1] == "o" && numbers[2][2] == "o" ||
      numbers[0][2] == "o" && numbers[1][1] == "o" && numbers[2][0] == "o"
    )
    {
        winOrLoss = true;
    }
}

// Функция проверяет доступен ли ход в клетку или нет  (вызывается в  свитче)
void checkingNextMove()
{
    Console.Write("Это клетка уже занята, повторите ввод: ");
    checkedUserNumber();
}

// Функция заполняет  клетку крестиком  или ноликом  ( вызывается в  свитче)
void changeCell(int changeCellI, int changeCellJ)
{
    moveCounter++;
    // Если ходили крестики то меняем переменную crossOrToe на нолики 
    if (whoseMove == true && crossOrToe == "x")
    {
        Console.Clear();
        numbers[changeCellI][changeCellJ] = crossOrToe;
        renderFileld(numbers); // функция отрисовывает поле
        whoseMove = false;
        crossOrToe = "o";



        checkedWin();  // функция проверяет есть победитель 
        // Если победителя нет и ходы еще есть (moveCounter < 10) то запрашиваем след. ход
        if (winOrLoss != true && moveCounter < 10)
        {
            Console.Write("Ходит следующий игрок o: ");
            checkedUserNumber(); // Функция проверяет чтобы пользователь ввел число вдиапазоне от 1 до 9 а не буквы  итд
        }
        else
        {
            if (winOrLoss == true)
            {// Проверяем что есть победитель а не закончились ходы и получилась ничья 
                Console.WriteLine("Победили крестики ");
            }
            else { Console.WriteLine("Боевая ничья"); }
        }

    }
    else
    {
        Console.Clear();
        numbers[changeCellI][changeCellJ] = crossOrToe;
        renderFileld(numbers); // функция отрисовывает поле
        whoseMove = true;
        crossOrToe = "x";
        checkedWin(); //  функция проверяет есть победитель 

        // Если победителя нет и ходы еще есть (moveCounter < 10) то запрашиваем след. ход
        if (winOrLoss != true && moveCounter < 10)
        {
            Console.Write("Ходит следующий игрок x: ");
            checkedUserNumber();// Функция проверяет чтобы пользователь ввел число в диапазоне от 1 до 9 а не буквы  итд
        }

        else
        { // Проверяем что есть победитель а не закончились ходы и получилась ничья 
            if (winOrLoss == true)
            {
                Console.WriteLine("Победили нолики");
            }
            else { Console.WriteLine("Боевая ничья"); }
        }
    }
}



// предлагаем выбор какой играть 
Console.WriteLine("Выберите фигуру для игры, если крестики нажмите букву х если нолики нажмите букву о");
whoGoesFirst = Console.ReadLine();

// пока пользователь не введет х или о будет запрашиваать ввод 
while (whoGoesFirst != "o" && whoGoesFirst != "x")
{
    Console.WriteLine("Выберите фигуру для игры, если крестики нажмите букву х если нолики нажмите букву о");
    whoGoesFirst = Console.ReadLine(); // запоминает выбор фигуры игрока который будет ходить первым 
}
// функция отрисовывает поле
renderFileld(numbers);

// Провеярем если пигрок ввел "x" то крестики ходят первыми 
if (whoGoesFirst == "x")
{
    whoseMove = true;
    crossOrToe = "x";
    Console.Clear();
    Console.WriteLine("Первыми ходят крестики");
    Console.WriteLine();
    renderFileld(numbers);
    Console.Write("Введите номер клетки: ");
    checkedUserNumber();
}
// Провеярем если пигрок ввел "o" то нолики ходят первыми 
else if (whoGoesFirst == "o")
{
    whoseMove = false;
    crossOrToe = "o";
    Console.WriteLine("Первыми ходят нолики");
    Console.WriteLine();
    Console.Write("Введите номер клетки: ");
    checkedUserNumber();
}


// Свитч который проверяет какую цифру ввел пользователь
while (moveCounter < 10 && winOrLoss != true)
{
    int changeCellI = 0; // параметры функции  changeCell() которая заполняет нужную клетку (массив numbers )ноликом или крестиком 
    int changeCellJ = 0;

    switch (number) // number переменая int которая хранит число которое ввел пользователь 
    {
        case 1:

            if (numbers[changeCellI][changeCellJ] == "x" || numbers[changeCellI][changeCellJ] == "o")
            {
                checkingNextMove(); // функция проверят что пользователь не пытается ввести клетку в которую сделан вход
            }
            else
            {
                changeCell(changeCellI, changeCellJ); // функция изменят клетку на нолик или крестик 
                break;
            }
            break;
        case 2:
            changeCellI = 0;
            changeCellJ = 1;
            if (numbers[changeCellI][changeCellJ] == "x" || numbers[changeCellI][changeCellJ] == "o")
            {
                checkingNextMove();
            }
            else
            {
                changeCell(changeCellI, changeCellJ);
                break;
            }
            break;
        case 3:
            changeCellI = 0;
            changeCellJ = 2;
            if (numbers[changeCellI][changeCellJ] == "x" || numbers[changeCellI][changeCellJ] == "o")
            {
                checkingNextMove();
            }
            else
            {
                changeCell(changeCellI, changeCellJ);
                break;
            }
            break;
        case 4:
            changeCellI = 1;
            changeCellJ = 0;
            if (numbers[changeCellI][changeCellJ] == "x" || numbers[changeCellI][changeCellJ] == "o")
            {
                checkingNextMove();
            }
            else
            {
                changeCell(changeCellI, changeCellJ);
                break;
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
                break;
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
                break;
            }
            break;
        case 7:
            changeCellI = 2;
            changeCellJ = 0;
            if (numbers[changeCellI][changeCellJ] == "x" || numbers[changeCellI][changeCellJ] == "o")
            {
                checkingNextMove();
            }
            else
            {
                changeCell(changeCellI, changeCellJ);
                break;
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
                break;
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
                break;
            }
            break;

    }

}




