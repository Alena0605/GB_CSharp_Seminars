// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Random rand = new Random();
int number = rand.Next(10, 100);
Console.WriteLine(number);

int digitOnes = number % 10;
int digitTens = number / 10;
int max = digitTens;

if (digitOnes > digitTens) max = digitOnes;

Console.WriteLine("Наибольшая цифра числа: " + max);
