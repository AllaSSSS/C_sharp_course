// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixProduct(int[,] array1, int[,] array2)
{
    int rows = array1.GetLength(0);
    int columns = array1.GetLength(1);
    int[,] resultingMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultingMatrix[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return resultingMatrix;
}

int[,] array1 = Fill2DArray(3, 4, 1, 10);
int[,] array2 = Fill2DArray(3, 4, 1, 10);
Print2DArray(array1);
Print2DArray(array2);
int[,] array3 = MatrixProduct(array1, array2);
Print2DArray(array3);