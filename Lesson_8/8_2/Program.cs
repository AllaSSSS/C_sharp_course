// 2. Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

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
            Console.Write($" {array[i, j], 2} ");
        } 
        Console.WriteLine();       
    }
    Console.WriteLine();
}

string RowsToColumns(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    if (rows != columns) return "Неодинаковое количество строк и столбцов";

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < i; j++)
        {
            (array[i, j], array[j, i]) = (array[j,i], array[i, j]);
        }

    }
    return "Произведена замена строк на столбцы";
}

Console.WriteLine("Введите число рядов: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число колонок: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] array = Fill2DArray(row, column, 1, 101);
Print2DArray(array);

Console.WriteLine (RowsToColumns(array));
Print2DArray(array);