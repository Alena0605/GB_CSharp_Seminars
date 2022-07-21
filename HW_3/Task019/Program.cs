// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;
int reverse = 0;
int remainder;

if (number > 9999 && number < 100000)
{
    while (copyNumber > 0)
    {
        remainder = copyNumber % 10;
        reverse = (reverse * 10) + remainder;
        copyNumber /= 10;
    }

    Console.WriteLine(reverse);

    if (reverse == number) Console.WriteLine($"Число {number} является полиндромом.");
    else Console.WriteLine($"Число {number} НЕ является полиндромом.");
}
else Console.WriteLine("Неверный ввод.");
