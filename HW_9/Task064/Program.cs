/* 
64. Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
*/

void NumbersMultiplyOfThree(int m, int n)
{
    if (m > n) return;
    
    if (m % 3 != 0) m++;
    else
    {
        Console.Write(m + "  ");
        m += 3;
    }
    NumbersMultiplyOfThree(m, n);
}

NumbersMultiplyOfThree(15, 29);
