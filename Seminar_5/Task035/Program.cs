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
35. Задайте одномерный массив из 10 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
*/

int size = 10;
int[] array = new int[size];

FillArray(array, -150, 151);
PrintArray(array);

int count = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] >= 10 && array[i] < 100) count++;
}

Console.WriteLine(count + " чисел в массиве находятся в промежутке [10, 99]");
