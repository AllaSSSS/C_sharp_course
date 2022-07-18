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

int[] FindSmallest(int[,] array)
{
    int smallest = array[0, 0];
    int[] position = {0, 0};
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < smallest)
            {
                smallest = array[i, j];
                position[0] = i;
                position[1] = j;
            }
        }
    }
    return position;
}

int[,] ModifyArray (int[,] array, int rowToRemove, int colToRemove)
{
    int rows = array.GetLength(0) - 1;
    int columns = array.GetLength(1) - 1;
    int[,] newArray = new int[rows, columns]; 

    for (int i = 0; i < rows; i++)
    {
        int i1 = i;
        if(i >= rowToRemove) i1++;
        for (int j = 0; j < columns; j++)
        {
            int j1 = j;
            if(j >= colToRemove) j1++;
            newArray[i, j] = array[i1, j1];
        }
    }
    return newArray;
}

int[,] array = Fill2DArray(4, 4, 1, 100);
Print2DArray(array);

int[] position = FindSmallest(array);

int[,] newArray = ModifyArray(array, position[0], position[1]);
Print2DArray(newArray);
