// Задать массив, заполненный случайными положительными трехзначными числами.
// Показать количество четных чисел в массиве.

void Fill(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] =  new Random().Next(100, 1000);
    }    
}

void Print(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
        if(i < length - 1) Console.Write(", ");
        else Console.WriteLine();
    }
}

int[] array = new int[new Random().Next(1, 20)];
Fill(array);
Print(array);

int CountEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    { 
        if(array[i] % 2 == 0) count += 1;
    }
    return count;
}

Console.WriteLine($"Количество четных чисел = {CountEven(array)}");
