// 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

void SumOfDigits(int number, int sum = 0)
{
    if (number == 0) 
    {
        Console.WriteLine("Сумма цифр в числе равна: " + sum);
        return;
    }
    sum += number % 10;
    number /= 10;
    SumOfDigits(number, sum);
}

SumOfDigits(589);
