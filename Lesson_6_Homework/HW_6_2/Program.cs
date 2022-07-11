// Пользователь вводит с клавиатуры М чисел. 
// Посчитать, сколько чисел больше нуля ввел пользователь.
 
int M = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите {M} числа/чисел: ");
int count = 0;

for (int i = 1; i <= M; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num > 0) count += 1;
}

Console.WriteLine($"Пользователь ввел {count} числа/чисел больше нуля.");
