// Программа принимает на вход число А и выдает сумму чисел от 1 до А.

int SumNum(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++) result += i;
    return result;
}

Console.WriteLine(SumNum(7));
