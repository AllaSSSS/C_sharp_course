// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов. (Для проверки добавила вывод суммы каждой строки).

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

(int, int) FindLine(int[,] array)
{
    int desiredLine = (0);
    int minSum = int.MaxValue;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"{i+1} = {sum}");
        if(sum < minSum) 
        {
            minSum = sum;
            desiredLine = i;
        }
    }
    return (desiredLine, minSum);
}

int[,] array = Fill2DArray(5, 6, 1, 100);
Print2DArray(array);

(int line, int sum) = FindLine(array);
Console.WriteLine();
Console.WriteLine($"Line {line + 1} has the smallest sum equal to {sum}");
