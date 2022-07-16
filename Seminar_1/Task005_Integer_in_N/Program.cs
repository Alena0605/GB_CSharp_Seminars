/* 
Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
*/

void Task_5()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);
    int startNumber = -number;

    while (startNumber != (number + 1))
    {
        Console.Write(startNumber + ",");
        startNumber++;
    }

    Console.Write("\b.");
    Console.WriteLine();
}

Task_5();
