/* 
69. Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
*/

int FindPow(int a, int b, int result = 1)
{
    if (b == 0) return result;
    result *= a;
    b--;
    return FindPow(a, b, result);
}

Console.WriteLine(FindPow(2, 10));
