// Программа замены элементов массива: полож. на отриц. и наоборот.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{       
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-9, 10);        
    }    
    return arr;
}

void Replace(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

int[] arr_1 = MassNums(12);
Print(arr_1);
Replace(arr_1);
Print(arr_1);
