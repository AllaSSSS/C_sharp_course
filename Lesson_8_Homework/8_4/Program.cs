// 1. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит 
// строку и столбец, на пересечении которых находится наименьший элемент.
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
            Console.Write($" {array[i, j], 2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

(int, int) FindSmallest(int[,] array)
{
    int smallest = array[0, 0];
    (int, int) position = (0, 0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < smallest)
            {
                smallest = array[i, j];
                position = (i, j);
            }
        }
    }
    Console.WriteLine($"Наименьший элемент массива равен {smallest}");
    return position;
}

void PrintNewArray (int[,] array, int rowToRemove, int colToRemove)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        if(i == rowToRemove) continue;
        for (int j = 0; j < columns; j++)
        {
            if(j == colToRemove) continue;
            Console.Write($" {array[i, j], 2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = Fill2DArray(4, 4, 1, 100);
Print2DArray(array);


(int rowToRemove, int colToRemove) = FindSmallest(array);

Console.WriteLine();

PrintNewArray(array, rowToRemove, colToRemove);

