// Задать массив из 123 случайных чисел, найти количество элементов, 
// значения которых лежат на отрезке [10, 99] 
 
 void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{       
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 1000);        
    }    
    return arr;
}

int CountNum(int[] arr)
{
    int count = 0;
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i] >= 10 && arr[i] <= 99) 
        {
            count += 1;
        }
    }
    return count;
}

int[] arr = MassNums(123);
Print(arr);
Console.WriteLine(CountNum(arr));
