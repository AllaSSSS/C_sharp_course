// 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз 
//    встречается элемент входных данных. Значения элементов массива 0..9

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
            Console.Write($" {array[i, j],2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] FrequencyDict(int[,] array)
{
    int[] array_1 = new int[10];
    foreach (int item in array) array_1[item]++;
    return array_1;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{i} - {array[i]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] array = Fill2DArray(row, column, 1, 10);
Print2DArray(array);
int[] dict = FrequencyDict(array);
PrintArray(dict);