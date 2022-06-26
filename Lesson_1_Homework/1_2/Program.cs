int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num2 > max) max = num3;

Console.Write("Максимальное число = ");
Console.WriteLine(max);