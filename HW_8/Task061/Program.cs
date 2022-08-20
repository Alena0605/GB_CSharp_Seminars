// 61. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Random random = new Random();

int rows1 = random.Next(1, 5);
int columns1 = random.Next(1, 5);
int[,] array1 = new int[rows1, columns1];

int rows2 = random.Next(1, 5);
int columns2 = random.Next(1, 5);
int[,] array2 = new int[rows2, columns2];

int[,] arrayMultiply = new int[rows1, columns2];

FillArray(array1);
Console.WriteLine("Матрица 1:");
PrintArray(array1);

Console.WriteLine();

FillArray(array2);
Console.WriteLine("Матрица 2:");
PrintArray(array2);

MultiplyArrays(array1, array2, arrayMultiply);


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

void MultiplyArrays(int[,] arrayA, int[,] arrayB, int[,] arrayC)
{
    int sizeRowsA = arrayA.GetLength(0);
    int sizeColumnsA = arrayA.GetLength(1);
    int sizeRowsB = arrayB.GetLength(0);
    int sizeColumnsB = arrayB.GetLength(1);

    if (sizeColumnsA == sizeRowsB)
    {
        for (int i = 0; i < sizeRowsA; i++)
        {
            for (int j = 0; j < sizeColumnsB; j++)
            {
                for (int k = 0; k < sizeColumnsA; k++)
                {
                    arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Произведение матриц A и B:");
        PrintArray(arrayC);
    }
    else Console.WriteLine("Матрицы умножать нельзя.");
}
