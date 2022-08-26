// 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void Recursion(int m, int n)
{
    if (m > n) return;
    Console.Write(m + " ");
    m++;
    Recursion(m, n);
}

Recursion(4, 8);
