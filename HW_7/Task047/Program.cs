// 47. Задайте двумерный массив размером M × N, заполненный случайными вещественными числами.

Random random = new Random();

int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
double[,] array = new double[rows, columns];

FillArray(array);
PrintArray(array);


// _______________БЛОК МЕТОДОВ_______________
//
//___________________________________________

void FillArray(double[,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber++;

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 100, 1);
        }
    }
}

void PrintArray(double[,] array)
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
