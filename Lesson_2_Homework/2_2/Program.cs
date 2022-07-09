int RemoveSecDig(int num)
{
    return num / 100 * 10 + num % 10;
}

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
Console.WriteLine(RemoveSecDig(num));