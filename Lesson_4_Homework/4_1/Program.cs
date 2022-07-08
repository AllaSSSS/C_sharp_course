// Цикл принимает на вход два числа А и В и возводит число А в степень В

int Power (int num1, int num2)
{
    int result = num1;
    for(int i = 1; i < num2; i++)
    {
        result *= num1;
    }
    return result;
}

Console.WriteLine("Введите два числа: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int result = Power(num1, num2);
Console.WriteLine(result);
