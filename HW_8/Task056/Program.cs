/* 
56. Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

int rows = 4;
int columns = 4;
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray2(array);

int[] arraySum = new int[rows];
int sum = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        sum += array[i, j];
    }
    arraySum[i] = sum;
    sum = 0;
}

Console.WriteLine();
PrintArray(arraySum);

int min = 0;
for (int k = 1; k < rows; k++)
{
    if (arraySum[k] < arraySum[min]) min = k;
}

Console.WriteLine($"Наименьшая сумма элементов в {min + 1} строке массива.");


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

void PrintArray2(int[,] array)
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

void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
