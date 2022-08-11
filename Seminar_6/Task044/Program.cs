// 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.WriteLine("Введите число: ");
int number  = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
array[0] = 0;
array[1] = 1;

Console.Write("0 1 ");

for (int i = 2; i < number; i++)
{
    array[i] = array[i - 2] + array[i - 1];
    Console.Write(array[i] + " ");
}

Console.WriteLine();

// ЕЩЕ ОДНО РЕШЕНИЕ
int numberFirst = 0;
int numberSecond = 1;

Console.WriteLine("Введите число: ");
int count = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    Console.Write(numberFirst + " ");
    (numberFirst, numberSecond) = (numberSecond, numberFirst + numberSecond);
}
