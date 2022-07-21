// Задайте значение N. Программа, которая выведет все натуральные числа от 1 до N c рекурсией.

void Values (int num)
{
    if (num == 0) return;
    Values (num - 1);
    Console.Write($"{num}, ");
}

Values(5);


