// Задать массив вещественных чисел. Найти разницу между максимальным элементом массива.

void Fill(double[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] =  new Random().Next(-100, 100);
    }    
}

void Print(double[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
        if(i < length - 1) Console.Write(", ");
        else Console.WriteLine();
    }
}

double[] array = new double[10];
Fill(array);
Print(array);

double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++) 
    {
        if(array[i] > max) max = array[i];
        else
        {
            if(array[i] < min) min = array[i];
        }
    }
    return max - min;
}

Console.WriteLine(DiffMaxMin(array));
