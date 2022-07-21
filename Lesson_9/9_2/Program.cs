// Задайте значения M и N. Напишите программу, которая 
// рекурсивно выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

void Sequence(int M, int N)
{
    if (N < M) return;
    Sequence(M, N-1);
    Console.Write($"{N}, ");
}
Sequence(M, N);