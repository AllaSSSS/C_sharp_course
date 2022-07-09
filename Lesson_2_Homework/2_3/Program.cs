int num = int.Parse(Console.ReadLine());

while (num > 1000)
{
    num = num / 10;
}

if (num < 100)
{
    Console.WriteLine("No third digit!");
}
else
{
    Console.WriteLine(num % 10);
}