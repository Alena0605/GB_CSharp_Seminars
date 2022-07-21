/* 
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

void Task18()
{
    Random random = new Random();
    int quarter = random.Next(0, 6);

    if (quarter == 1) Console.WriteLine("Координаты 1-ой четверти (x > 0) и (y > 0)");
    else if (quarter == 2) Console.WriteLine("Координаты 2-ой четверти (x < 0) и (y > 0)");
    else if (quarter == 3) Console.WriteLine("Координаты 3-ей четверти (x < 0) и (y < 0)");
    else if (quarter == 4) Console.WriteLine("Координаты 4-ой четверти (x > 0) и (y < 0)");
    else Console.WriteLine("Неверный ввод.");
}

for (int i = 1; i < 10; i++)
Task18();
