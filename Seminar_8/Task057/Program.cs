/* 
57. Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
*/

Random random = new Random();

int rows = random.Next(4, 6);
int columns = random.Next(4, 6);
int[,] array = new int[rows, columns];

FillArray(array, 0, 9);
PrintArray(array);

int[] counter = new int[10];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        counter[array[i, j]]++;
    }
}

for (int k = 0; k < counter.Length; k++)
{
    if (counter[k] != 0) Console.WriteLine($"Число {k} встречается {counter[k]} раз");
}


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
