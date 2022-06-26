int num = int.Parse(Console.ReadLine());
int count = 2;

while (count <= num)
{
    if (count > 2) Console.Write(", ");
    
    Console.Write(count);
    count += 2;
}
Console.WriteLine();