// _____________Блок вспомогательных методов_____________
//
//_______________________________________________________

void FillFloatArray(double[] array, int startNumber = -10, int finishNumber = 10)
{
    finishNumber++;
    Random number = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((number.NextDouble() + number.Next(startNumber, finishNumber)), 2);
    }
}

void PrintFloatArray(double[] array)
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

// 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

int size = 6;
double[] arrayNumbers = new double[size];

FillFloatArray(arrayNumbers);
PrintFloatArray(arrayNumbers);

double minNumber = arrayNumbers[0];
double maxNumber = arrayNumbers[0];

for (int i = 1; i < size; i++)
{
    if (arrayNumbers[i] < minNumber) 
    {
        minNumber = arrayNumbers[i];
    }
    else if (arrayNumbers[i] > maxNumber) 
    {
        maxNumber = arrayNumbers[i];
    }
}

Console.WriteLine($"Минимальное число массива = {minNumber}");
Console.WriteLine($"Максимальное число массива = {maxNumber}");

double result = maxNumber - minNumber;
Console.WriteLine("Разница между максимальным и минимальным числами массива равна: " + Math.Round(result, 2));
