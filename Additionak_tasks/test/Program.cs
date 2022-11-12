// Console.Clear();
Console.WriteLine();

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

    int j = 0;
    Console.WriteLine("_____________________________");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("|   |   |   |   |   |   |   |");
        Console.WriteLine("|   |   |   |   |   |   |   |");


        for (j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("|_" + arr[i, j] + "_");
        }


        Console.WriteLine("|");



    }
}

ShowArray(playField);
Console.WriteLine();

