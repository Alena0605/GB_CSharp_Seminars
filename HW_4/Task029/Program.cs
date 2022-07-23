// 29. Напишите программу, которая задаёт массив из 8 элементов и выводит отсортированный по модулю массив.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
}

void SortedArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            int abs = Math.Abs(array[j]);
            int absMinPos = Math.Abs(array[minPos]);
            
            if (abs < absMinPos) minPos = j;
        }

        int temporary = array[i];
        array[i] = array[minPos];
        array[minPos] = temporary;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int size = 8;
int[] arrayNumbers = new int[size];

FillArray(arrayNumbers);
SortedArray(arrayNumbers);
PrintArray(arrayNumbers);
