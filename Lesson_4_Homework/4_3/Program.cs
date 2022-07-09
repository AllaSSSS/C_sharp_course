// Задает массив из 8 элементов случайными числами и выводит их на экран 
// (использовать FillArray и PrintArray)

void Fill(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] =  new Random().Next();
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

int[] array = new int[8];

Fill(array);
Print(array);

