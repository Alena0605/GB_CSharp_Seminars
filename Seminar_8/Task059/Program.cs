/* 
59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
*/

Random random = new Random();

int rows = random.Next(4, 6);
int columns = random.Next(4, 6);
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);

int min = array[0, 0];
int min_i = 0;
int min_j = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (array[i, j] < min) 
        {
            min = array[i, j];
            min_i = i;
            min_j = j;
        }
    }
}
Console.WriteLine($"Минимальный элемент равен {min} ({min_i}, {min_j})");

int[,] arraySecond = new int[rows - 1, columns - 1];
int rowsSecond = arraySecond.GetLength(0);
int columnsSecond = arraySecond.GetLength(1);
int bias_k = 0;
int bias_l = 0;

for (int k = 0; k < rowsSecond; k++)
{
    if (k == min_i) bias_k++;
    bias_l = 0;
    for (int l = 0; l < columnsSecond; l++)
    {
        if (l == min_j) bias_l++;
        arraySecond[k, l] = array[k + bias_k, l + bias_l];
    }
}

Console.WriteLine();
PrintArray(arraySecond);


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
