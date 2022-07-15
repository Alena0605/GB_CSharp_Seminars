// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result;
result = number * number;
Console.WriteLine($"{number} ^ 2 = {result}");
