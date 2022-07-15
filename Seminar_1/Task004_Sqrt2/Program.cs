// Напишите программу вычисления значения функции возведения числа в квадрат.

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Power(number1));

Console.Write("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
PowerProcedural(number2);


// Функция
int Power(int currentNumber)
{
    return currentNumber * currentNumber;
}

// Процедура
void PowerProcedural(int currentNumber)
{
    Console.WriteLine(currentNumber * currentNumber);
}
