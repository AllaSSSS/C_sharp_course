// 1. Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
int[,] Fill2DArray(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
    {   
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(from, to);
        }        
    }
    return array;
}

void Print2DArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($" {array[i, j]} ");
        } 
        Console.WriteLine();       
    }
    Console.WriteLine();
}

void ReplaceRows(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < columns; i++)
    {
        (array[0, i], array[rows - 1, i]) = (array[rows - 1, i], array[0, i]);
    }
}

Console.WriteLine("Введите число рядов: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число колонок: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] array = Fill2DArray(row, column, 1, 101);
Print2DArray(array);

ReplaceRows(array);
Print2DArray(array);