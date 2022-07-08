// Принимает на вход число и выдает количество цифр в числе

int DigitCount(int num)
{
    string result = num.ToString();
    return result.Length;
}

Console.WriteLine(DigitCount(456));
