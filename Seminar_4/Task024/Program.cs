// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

void Task24()
{
    Random rand = new Random();
    int number = rand.Next(1, 10);
    Console.WriteLine($"Число {number}");

    int sum = 0;
    int i = 1;

    while (i <= number)
    {
        sum += i;
        Console.Write(i + " + ");
        i++;
    }

    Console.Write("\b\b= ");
    Console.WriteLine(sum);
}

for (int i = 1; i < 5; i++)
Task24();
