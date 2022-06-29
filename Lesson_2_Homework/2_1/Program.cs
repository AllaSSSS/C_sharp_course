int GetSecDig(int num)
{
    return num / 10 % 10;
}

int num = int.Parse(Console.ReadLine());
Console.WriteLine(GetSecDig(num));