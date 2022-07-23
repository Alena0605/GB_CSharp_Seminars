// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

void Task28()
{
    Random rand = new Random();
    int number = rand.Next(1, 10);
    Console.WriteLine($"Число {number}");

    int mult = 1;
    int i = 1;

    while (i <= number)
    {
        mult *= i;
        Console.Write(i + " * ");
        i++;
    }

    Console.Write("\b\b= ");
    Console.WriteLine(mult);
}

for (int i = 1; i < 5; i++)
Task28();
