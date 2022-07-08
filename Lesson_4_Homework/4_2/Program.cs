// Принимает на вход число и выдает сумму цифр в числе

int SumOfDigits(int num)
{
    int result = 0; 
    while(num >= 1)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = SumOfDigits(num);
Console.WriteLine(result);
