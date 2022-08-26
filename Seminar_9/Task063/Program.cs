// 63.  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void Recursion(int number, int counter = 1)
{
    if (counter > number) return;
    Console.WriteLine(counter);
    counter++;
    Recursion(number, counter);
}

Recursion(5);
