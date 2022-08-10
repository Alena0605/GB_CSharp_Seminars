// _____________Блок вспомогательных методов_____________
//
// ______________________________________________________

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

void SumPositive(int[] array)
{
    int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositive += array[i];
    }
    Console.WriteLine("Сумма положительных элементов массива равна " + sumPositive);
}

void SumNegative(int[] array)
{
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative += array[i];
    }
    Console.WriteLine("Сумма отрицательных элементов массива равна " + sumNegative);
}


// _____________Блок решения задачи_____________
//
// _____________________________________________

/* 
31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
*/

int size = 12;
int[] array = new int[size];

FillArray(array, -9, 9);
PrintArray(array);

SumPositive(array);
SumNegative(array);
