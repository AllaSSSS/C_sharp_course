// Программа на вход принимает позиции элемента в двумерном массиве и возвращает значение
// этого элемента в массиве или указание, что такого элемента нет.

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

int[,] array = Fill2DArray(10, 10, 0, 100);
Print2DArray(array);

Console.Write("Введите строку, в которой находится элемент: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите столбец, в котором находится элемент: ");
int column = int.Parse(Console.ReadLine());

if (row < 1 || column < 1 || row > array.GetLength(0) || column > array.GetLength(1))
    {
        Console.WriteLine ("Такого элемента не существует.");
    } 
else
{
    Console.WriteLine($"На позиции {row};{column} находится {array[row-1, column-1]}");
}