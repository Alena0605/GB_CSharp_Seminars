// 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Сколько чисел вы хотите ввести: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 1; i <= numbers; i++)
{
    Console.Write($"Введите {i}-е число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    if (number > 0) count++;
}

Console.WriteLine($"Из введенных чисел больше 0: {count}");
