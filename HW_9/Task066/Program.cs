/* 
66. Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*/

void SumNumbers(int m, int n, int sum = 0)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма чисел в заданном промежутке равна {sum}.");
        return;
    } 

    sum += m;
    m++;
    SumNumbers(m, n, sum);
}

SumNumbers(1, 15);
