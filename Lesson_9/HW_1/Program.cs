// Задайте числа M и N. Напишите программу, которая выведет 
// все четные натуральные числа в промежутке от М до N c рекурсией.

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

void AllEvens(int M, int N)
{
    if (N % 2 == 1) N = N - 1;
    else if (N < M) return; 
    else AllEvens(M, N - 2);
    Console.Write($"{N}, ");
}
AllEvens(M, N);
