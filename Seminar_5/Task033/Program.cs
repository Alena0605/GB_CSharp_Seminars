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

// 33.  Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int size = 10;
int[] array = new int[size];

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

FillArray(array);
PrintArray(array);

bool flag = false;
for (int i = 0; i < size; i++)
{
    if (array[i] == number)
    {
        flag = true;
        break;
    }
}

if (flag) Console.WriteLine($"Число {number} есть в массиве");
else Console.WriteLine($"Числа {number} нет в массиве");
