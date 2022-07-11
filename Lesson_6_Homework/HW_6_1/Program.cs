// Написать программу поэлементного копирования двумерного массива

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write ($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    Console.WriteLine();
    }
}

int[,] CopyArray(int[,] matrix)
{
    int[,] matrixcopy = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixcopy[i, j] = matrix[i, j];
        }
    }
    return matrixcopy;
}

int[,] matrix = new int [3, 4];
FillArray (matrix);
PrintArray (matrix);
int[,] matrixcopy = CopyArray(matrix);
PrintArray(matrixcopy);


