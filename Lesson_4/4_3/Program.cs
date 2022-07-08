// Принимает число N и выдает произведение от 1 до N
int Product(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++) result *= i;
    return result;
}

Console.WriteLine(Product(4));
