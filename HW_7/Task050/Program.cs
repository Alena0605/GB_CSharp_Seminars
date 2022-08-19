/* 
50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

Random random = new Random();

int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);

Console.WriteLine("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

if (row <= rows && column <= columns) 
{
    Console.WriteLine($"Число в массиве с индексами [{row}, {column}] равно: {array[row, column]}");
}
else Console.WriteLine($"Числа в массиве с индексами [{row}, {column}] нет.");


// _______________БЛОК МЕТОДОВ_______________
//
//___________________________________________

void FillArray(int[,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
