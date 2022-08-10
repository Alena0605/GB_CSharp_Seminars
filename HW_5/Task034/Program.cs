// _____________Блок вспомогательных методов_____________
//
//_______________________________________________________

void FillArray(int[] array, int startNumber = -10, int finishNumber = 10)
{
    finishNumber++;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(startNumber, finishNumber);
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


// _____________Блок решения задачи_____________
//
// _____________________________________________

/*
34. Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/

int size = 10;
int[] arrayNumbers = new int[size];

FillArray(arrayNumbers, 100, 999);
PrintArray(arrayNumbers);

int count = 0;
for (int i = 0; i < size; i++)
{
    if (arrayNumbers[i] % 2 == 0) count++;
}

Console.WriteLine("Количество четных чисел в массиве: " + count);
