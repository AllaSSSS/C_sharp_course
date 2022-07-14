// Задать двумерный массив размерами mxn, заполненный случайными вещественными числами.

double[,] Fill2DArray(int row, int column, double from, double to)
{
    double[,] array = new double[row, column];
    Random n_new = new Random();

    for (int i = 0; i < row; i++)
    {   
        for (int j = 0; j < column; j++)
        {
            array[i, j] = Math.Round(from + n_new.NextDouble() * (to - from), 2);
        }        
    }
    return array;
}

void Print2DArray(double[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {array[i, j]} ");
        } 
        Console.WriteLine();       
    }
    Console.WriteLine();
}

double[,] array = Fill2DArray(4, 5, -100, 100);
Print2DArray(array);