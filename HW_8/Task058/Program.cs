// 58.  Заполните спирально массив 4 на 4 числами от 1 до 16.

int size = 4;
int[,] array = new int[size, size];

int numbers = size * size;
int number = 1;
int i = 0;
int j = 0;

while (number <= numbers)
{
    array[i, j] = number;
    if (i <= j + 1 && i + j < size - 1) j++;
    else if (i < j && i + j >= size - 1) i++;
    else if (i >= j && i + j > size - 1) j--;
    else i--;

    number++;
}

PrintArray(array);


// _______________БЛОК МЕТОДОВ_______________
//
//___________________________________________

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
