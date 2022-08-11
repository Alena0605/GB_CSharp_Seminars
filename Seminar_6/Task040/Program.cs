/*
40. Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник со сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

void FillArray(int[] array)
{
    int size = array.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

bool SideCheck(int sideA, int sideB, int sideC)
{
    return (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB);
}


int size = 3;
int[] array = new int[size];

FillArray(array);
PrintArray(array);

Console.WriteLine($"Сторона A = {array[0]}, сторона B = {array[1]}, сторона C = {array[2]}");

if (SideCheck(array[0], array[1], array[2])) Console.WriteLine("Треугольник с такими сторонами может существовать.");
else Console.WriteLine("Треугольник с такими сторонами существовать не может.");
