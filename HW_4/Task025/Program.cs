// 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void Pow(int num1, int num2)
{
    int result = 1;

    for (int i = 0; i < num2; i++)
    {
        result *= num1;
    }

    Console.WriteLine($"{num1}^{num2} = {result}");
}


Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Pow(numberA, numberB);
