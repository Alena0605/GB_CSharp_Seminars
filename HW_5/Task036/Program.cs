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
36. Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/

int size = 10;
int[] arrayNumbers = new int[size];

FillArray(arrayNumbers);
PrintArray(arrayNumbers);

int sum = 0;
for (int i = 1; i < size; i += 2)
{
    sum += arrayNumbers[i];
}

Console.WriteLine("Сумма чисел: " + sum);
