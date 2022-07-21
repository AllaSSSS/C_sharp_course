// Задайте числа M и N. Напишите программу, которая найдет сумму 
// натуральных элементов в промежутке от М до N c рекурсией.


int SumOfElements(int M, int N)
{
    if (N < M) return 0; 
    else return N + SumOfElements(M, N - 1);
}

Console.WriteLine(SumOfElements(1, 15));
