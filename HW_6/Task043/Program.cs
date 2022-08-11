/* 
43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями: 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/

Random rand = new Random();

double b1 = Convert.ToDouble(rand.Next(0, 11));
double k1 = Convert.ToDouble(rand.Next(0, 11));
double b2 = Convert.ToDouble(rand.Next(0, 11));
double k2 = Convert.ToDouble(rand.Next(0, 11));

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");

if (k1 == k2 && b1 != b2) 
{
    Console.WriteLine("Прямые параллельны.");
}
else if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают.");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения прямых [{Math.Round(x, 2)}, {Math.Round(y, 2)}]");
}
