// Программа, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

void Cube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
        count++;
    }
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Cube(num);