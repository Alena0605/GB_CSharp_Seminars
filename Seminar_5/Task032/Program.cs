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
32. Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
*/


