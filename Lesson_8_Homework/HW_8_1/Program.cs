// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки массива.

int[,] Fill2DArray(int rows, int columns, int from, int to)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
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
            Console.Write($" {array[i, j],2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            if (array[i, j] < array[i, k])
            {
                (array[i, j], array[i, k]) = (array[i, k], array[i, j]);
            }
        }
    }
    return array;
}

int[,] array = Fill2DArray(5, 6, 1, 100);
Print2DArray(array);

int[,] sortedArray = SortRows(array);
Print2DArray(sortedArray);
