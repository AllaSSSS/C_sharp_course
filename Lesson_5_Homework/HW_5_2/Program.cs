// Задать одномерный массив со случайными числами. Найти сумму элементов на нечетных позициях.

void Fill(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] =  new Random().Next(1, 20);
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

int[] array = new int[10];
Fill(array);
Print(array);

int SumOddPos(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    { 
        if(i % 2 == 0) sum += array[i];
    }
    return sum;
}

Console.WriteLine($"Сумма элементов на нечетных позициях = {SumOddPos(array)}");
