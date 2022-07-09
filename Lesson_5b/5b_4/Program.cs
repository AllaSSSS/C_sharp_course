// Произведение пар чисел (первое с посл., второе с предпосл. и т.д.) в одномерном массиве. 
// Результат записать в новом массиве.

void Fill(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] =  new Random().Next(1, 10);
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

int[] ProductOfPairs(int[] array)
{
    int[] result = new int[(array.Length + 1) / 2];
    for(int i = 0, j = array.Length - 1; i <= j; i++, j--)
    {
        result[i] = array[i] * array[j];
    }
    return result;
}

Print(ProductOfPairs(array));