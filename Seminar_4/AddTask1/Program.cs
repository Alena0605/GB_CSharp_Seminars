/* 
Даны два массива. В первом массиве записано количество мячей, забитых футбольной командой в той или иной игре,
во втором - количество пропущенных мячей в этой же игре.
а) Для каждой проведенной игры напечатать словесный результат: "выигрыш", "ничья" или "проигрыш".
б) Определить количество выигрышей данной команды.
в) Определить количество выигрышей и количество проигрышей данной команды.
г) Определить количество выигрышей, количество ничьих и количество проигрышей данной команды.
д) Определить, в скольких играх разность забитых и пропущенных мячей была большей или равной трем.
е) Определить общее число очков, набранных командой (за выигрыш дается 3 очка, за ничью - 1, за проигрыш - 0).
*/

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
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


Random rand = new Random();
int size = rand.Next(6, 10);
int[] goals = new int[size];
int[] miss = new int[size];

FillArray(goals);
Console.WriteLine("Забитые мячи: ");
PrintArray(goals);

FillArray(miss);
Console.WriteLine("Пропущенные мячи: ");
PrintArray(miss);

// а) Для каждой проведенной игры напечатать словесный результат: "выигрыш", "ничья" или "проигрыш".
// в) Определить количество выигрышей и количество проигрышей данной команды.
// е) Определить общее число очков, набранных командой (за выигрыш дается 3 очка, за ничью - 1, за проигрыш - 0).

int wins = 0;
int loses = 0;
int draw = 0;

int scores = 0;

Console.WriteLine();

for (int i = 0; i < goals.Length; i++)
{
    int scored = goals[i];
    int conceded = miss[i];

    Console.Write($"{scored}:{conceded}");

    if (scored > conceded) 
    {
        Console.WriteLine($" - Победа");
        wins++;
        scores += 3;
    }
    else if (scored < conceded)
    {
        Console.WriteLine(" - Поражение");
        loses++;
    }
    else
    {
        Console.WriteLine(" - Ничья");
        draw++;
        scores++;
    }
}

Console.WriteLine();
Console.WriteLine($"Побед - {wins}, поражений - {loses}, ничьих - {draw}.");
Console.WriteLine("Набрано очков: " + scores);
