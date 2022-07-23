// Задайте числа M и N. Напишите программу, которая выведет 
// все четные натуральные числа в промежутке от М до N c рекурсией.

// Console.Write("Введите число M: ");
// int M = int.Parse(Console.ReadLine());

// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());

// void AllEvens(int M, int N)
// {
//     if (N % 2 == 1) N = N - 1;
       
//     if (N < M) return;
//     else AllEvens(M, N - 2);
//     Console.Write($"{N}, ");
// }
// AllEvens(M, N);

string AllEvens(int M, int N)
{
    if (M % 2 == 1) M = M+1; 

    if (M <= N) 
    {
        if (N - M >= 2) return $"{M}, " + AllEvens(M+2, N);
        else return M.ToString();
    }
    else return String.Empty;
}

Console.WriteLine(AllEvens(11, 28));
Console.WriteLine(AllEvens(10, 28));
Console.WriteLine(AllEvens(11, 29));
Console.WriteLine(AllEvens(10, 29));
string s = AllEvens(10, 29);
Console.WriteLine(s.Substring(0, s.Length-4));