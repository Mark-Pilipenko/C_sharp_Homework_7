// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого элемента в массиве нет

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array= new int[m,n];
FillArray(array);
PrintArray(array);

Console.Write("Введите индекс строки элемента: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца элемента: ");
int b = Convert.ToInt32(Console.ReadLine());
FindElement(a,b,array);

void FindElement(int row, int column, int[,] matrix)
{
    if (row > matrix.GetLength(0) - 1 || column > matrix.GetLength(1) - 1) Console.WriteLine($"Элемента с индексами [{row},{column}] в этом массиве нет!");
    else Console.WriteLine($"Элемент с индексами [{row},{column}] : {matrix[row,column]}");
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}