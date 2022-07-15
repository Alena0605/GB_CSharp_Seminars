// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result;
result = numberA * numberA;

if(result == numberB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
