Console.Write("Enter day of week: ");
int num = int.Parse(Console.ReadLine());

if (num < 1 || num > 7)
{
    Console.WriteLine("Error");
}
else
{
    if (num == 6 || num == 7)
        {
        Console.WriteLine("Yes");
        }
    else 
    {
        Console.WriteLine("No");
    }
}
