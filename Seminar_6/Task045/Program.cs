// 45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. 

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

void CopyArray(int[] array1, int[] array2)
{
    int size = array1.Length;
    for (int i = 0; i < size; i++)
    {
        array2[i] = array1[i];
    }
}


int size = 10;
int[] array = new int[size];
int[] copyArray = new int[size];

FillArray(array);
PrintArray(array);

CopyArray(array, copyArray);
PrintArray(copyArray);
