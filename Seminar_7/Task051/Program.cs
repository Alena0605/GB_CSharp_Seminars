/* 
51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1,1) и т.д.).
*/

Random random = new Random();

int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);

int sum = 0;
for (int k = 0; k < rows; k++)
{
    for (int l = 0; l < columns; l++)
    {
        if (k == l) sum += array[k, l];
    }
}

Console.WriteLine($"Сумма чисел на главной диагонали равна: {sum}");


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
