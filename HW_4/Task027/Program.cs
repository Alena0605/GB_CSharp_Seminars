// 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int copyNumber = number;
int remainder;
int result = 0;

while (copyNumber > 0)
{
    remainder = copyNumber % 10;
    result += remainder;
    copyNumber /= 10;
}

Console.WriteLine($"Сумма цифр в числе {number} = {result}");
