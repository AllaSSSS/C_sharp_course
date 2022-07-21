// / 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.

int Numbers(int num)

{
    if (num == 0) return 0;
    return Numbers(num / 10) + num % 10;
}

Console.WriteLine(Numbers(1256));
