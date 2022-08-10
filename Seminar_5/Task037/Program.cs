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
37. Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
*/

int size = 7;
int[] array = new int[size];

FillArray(array, 0, 10);
PrintArray(array);

int halfSize = size / 2;
int maxIndex = size - 1;
int[] result = new int[halfSize + size % 2];

for (int i = 0; i < halfSize; i++)
{
    result[i] = array[i] * array[maxIndex - i];
    Console.WriteLine($"{array[i]} * {array[maxIndex - i]} = {array[i] * array[maxIndex - i]}");
}

if (size % 2 == 1)
{
    result[halfSize] = array[halfSize];
    Console.WriteLine("Средний элемент: " + array[halfSize]);
} 

PrintArray(result);
