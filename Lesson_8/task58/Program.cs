/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


// int rows = new Random().Next(3, 10);
// int columns = new Random().Next(3, 10);
int columns = 3;
int rows = 3;
// int[,] myArray = CreateArray(rows, columns);
// int[,] myArray2 = CreateArray(rows, columns);

int[,] myArray = {
    { 1, 2, 2},
    { 1, 2, 0},
    { 2, 3, 3},
};
int[,] myArray2 = {
    { 1, 2, 2},
    { 2, 1, 0},
    { 2, 1, 2}
};

PrintArray(myArray);
PrintArray(myArray2);
Console.WriteLine("_________");
PrintArray(MultipliesMatrices(myArray, myArray2));

// Функция печатает массив
void PrintArray(int[,] arr)
{
    Console.WriteLine("--------------------------");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");

        }
        Console.WriteLine($" ");
    }

}
// Функция создает двумерный массив 
// int[,] CreateArray(int rows, int columns)
// {
//     int[,] arr = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             arr[i, j] = new Random().Next(1, 4);
//         }
//     }
//     return arr;
// }
int[,] MultipliesMatrices(int[,] arr, int[,] arr1)
{
    int[,] result = new int[arr.GetLength(0), arr1.GetLength(1)];
    int sum = 0;
    int j = 0;
    if (arr.GetLength(1) != arr1.GetLength(0))
    {
        Console.WriteLine("Перемножение невозможно количество столбцов первой матрицы не совпадает с количетвом строк второй матрицы ");
    }
    else
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (j = 0; j < arr.GetLength(1); j++)
            {
                sum = sum + arr[i, j] * arr1[j, i];
                result[i, j] = sum;
                // Console.Write(sum + "! ");
                // Console.Write(String.Join(";", result));
            }
            Console.WriteLine();
            sum = 0;
        }
    }
    // Console.Write(String.Join(";", result));
    return result;
}




/*


{
    "version": "0.2.0",
    "configurations": [

        {
            // Use IntelliSense to find out which attributes exist for C# debugging
            // Use hover for the description of the existing attributes
            // For further information visit https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger-launchjson.md
            "name": ".NET Core Launch (console)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build",
            // If you have changed target frameworks, make sure to update the program path.
            "program": "${workspaceFolder}/Lesson_8/task54/bin/Debug/net6.0/task54.dll",
            "args": [],
            "cwd": "${workspaceFolder}/Lesson_8/task54",
            // For more information about the 'console' field, see https://aka.ms/VSCode-CS-LaunchJson-Console
            "console": "internalConsole",
            "stopAtEntry": false
        },
        {
            "name": ".NET Core Attach",
            "type": "coreclr",
            "request": "attach"
        }
    ]
}
*/