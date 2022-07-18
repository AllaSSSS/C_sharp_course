// Десятичное число в двоичное.

void DecToBinary(int number)
{
    string Binary = "";
    while (number > 0)
    {
        Binary = number % 2 + Binary;
        number /= 2;
    }
    Console.WriteLine(Binary);
}

DecToBinary(10);

