// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Task023()
{
    Random random = new Random();
    int number = random.Next(1, 10);
    Console.WriteLine($"Задано число {number}");

    for (int i = 1; i <= number; i++) Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
}

for (int i = 1; i < 5; i++)
Task023();
