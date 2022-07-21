/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
выдаёт номер четверти плоскости, в которой находится эта точка.
*/

void Task17()
{
    Random random = new Random();
    int x = random.Next(-10, 11);
    int y = random.Next(-10, 11);
    Console.WriteLine($"Точка с координатами ({x}, {y})");

    if (x > 0 && y > 0) Console.WriteLine("Точка лежит в 1-ой четверти.");
    else if (x < 0 && y > 0) Console.WriteLine("Точка лежит в 2-ой четверти.");
    else if (x < 0 && y < 0) Console.WriteLine("Точка лежит в 3-ой четверти.");
    else if (x > 0 && y < 0) Console.WriteLine("Точка лежит в 4-ой четверти.");
    else Console.WriteLine("Точка лежит на координатной прямой.");
}

for (int i = 1; i < 10; i++)
Task17();
