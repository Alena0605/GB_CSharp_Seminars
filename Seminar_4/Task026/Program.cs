// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (number > 0)
{
    number /= 10;
    count++;
}

Console.WriteLine("Цифр в числе: " + count);
