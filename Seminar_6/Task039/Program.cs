/* 
39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
а первый - на последнем и т.д.)
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

void Reverse(int[] array)
{
    int size = array.Length;
    int halfSize = size / 2;
    int maxIndex = size - 1;

    for (int i = 0; i < halfSize; i++)
    {
        int temp = array[i];
        array[i] = array[maxIndex - i];
        array[maxIndex - i] = temp;

        // Можно решить с помощью кортежа:
        // (array[i], array[maxIndex - i]) = (array[maxIndex - i], array[i]);
    }
}


int size = new Random().Next(5, 11);
int[] array = new int[size];

FillArray(array);
PrintArray(array);

Reverse(array);
PrintArray(array);
