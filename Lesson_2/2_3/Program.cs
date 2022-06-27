// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.

void OneOfNum(int num_1, int num_2)
{       
    if (num_1 % num_2 == 0)
    {
        Console.WriteLine($"{num_1}, {num_2} -> multiple");
    }
    else
    {
        Console.WriteLine($"{num_1}, {num_2} -> not multiple, the remainder {num_1 % num_2}");        
    }    
}

OneOfNum(16, 4);
OneOfNum(22, 4);