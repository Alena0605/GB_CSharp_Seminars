// 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
int bias = 1;

while (number > 0)
{
    result = result + number % 2 * bias;
    bias *= 10;
    number /= 2;
}

Console.Write(result);
