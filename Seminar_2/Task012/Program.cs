/* 
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
*/

Console.WriteLine("Введите первое число (оно должно быть меньше второго): ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число (оно должно быть больше первого): ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number2 % number1;

if (result == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {result}");
}
