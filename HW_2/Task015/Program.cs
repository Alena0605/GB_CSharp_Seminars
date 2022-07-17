/* 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
*/

string[] weekDays = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine($"{weekDays[number-1]} - это выходной");
}
else if (number >= 1 && number <= 5)
{
    Console.WriteLine($"{weekDays[number-1]} - это НЕ выходной");
}
else
{
    Console.WriteLine("Дня недели с таким номером не бывает.");
}
