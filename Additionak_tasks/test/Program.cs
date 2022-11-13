Console.Clear();
Console.WriteLine("         TETRIS GAME");

// Поле для тетриса 
/*
string[,] playField = new string[,]
{
    { "1", "2", "3", "4", "5", "6","7"},
    { "1", "2", "3", "4", "5", "6","7"},
    { "1", "2", "3", "4", "5", "6","7"},
    { "1", "2", "3", "4", "5", "6","7"},
    { "1", "2", "3", "4", "5", "6","7"},
    { "1", "2", "3", "4", "5", "6","7"},
    { "1", "2", "3", "4", "5", "6","7"},
    { "1", "2", "3", "4", "5", "6","7"}
};

void ShowArray(string[,] arr)
{
    Console.WriteLine("_____________________________");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("|   |   |   |   |   |   |   |");
        Console.WriteLine("|   |   |   |   |   |   |   |");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("|_" + arr[i, j] + "_");
        }
        Console.WriteLine("|");
    }
}

*/
// Массив поле для игры в тетрис

string[,] playField = new string[,]
{
    { "                           |"},
    { "                           |"},
    { "                           |"},
    { "                           |"},
    { "                           |"},
    { "                           |"},
    { "                           |"},
    { "                           |"},
    { "                           |"},
    { "                           |"},
    { "                           |"},

};
// Отрисовывает массив поле для игры в тетрис
void ShowArray(string[,] arr)
{
    Console.Clear();
    Console.WriteLine("_____________________________");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("|                           |");
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            Console.Write("|" + arr[i, j]);
        }
        Console.WriteLine();
    }
}

ShowArray(playField);
Console.WriteLine("|___________________________|");
Console.WriteLine();
