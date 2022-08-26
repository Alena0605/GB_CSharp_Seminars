// 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

int FunAckermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return FunAckermann(m - 1,1);
    else return FunAckermann(m - 1, FunAckermann(m, n - 1));
}

Console.WriteLine(FunAckermann(3, 2));
