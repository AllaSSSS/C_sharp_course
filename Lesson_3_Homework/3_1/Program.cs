// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();

if (num.Length != 5)
{
    Console.WriteLine("Wrong number!");
    return;
}

if (num[0] == num[4] && num[1] == num[3]) Console.WriteLine("Yes"); 
else Console.WriteLine("No");