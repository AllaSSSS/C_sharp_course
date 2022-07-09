// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.

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
void NumAvail(int[] arr, int num)
{
    string flag = "no";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) 
        {
            flag = "yes";
            break;
        }
    }
    Console.WriteLine(flag);
}
int[] arr_1 = MassNums(12);
Print(arr_1);
NumAvail(arr_1, 4);
