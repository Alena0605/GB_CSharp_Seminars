/* 
Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 2D пространстве.
*/

void Task21()
{
    Random random = new Random();
    int x1 = random.Next(-10, 11);
    int y1 = random.Next(-10, 11);
    int x2 = random.Next(-10, 11);
    int y2 = random.Next(-10, 11);
    Console.WriteLine($"Заданы две точки с координатами A({x1}, {y1}) и B({x2}, {y2}).");

    double x = Math.Pow((x2 - x1), 2);
    double y = Math.Pow((y2 - y1), 2);
    double result = Math.Sqrt(x + y);

    Console.WriteLine($"Расстояние между точками равно {Math.Round(result, 2)}");
}

for (int i = 1; i < 10; i++)
Task21();
