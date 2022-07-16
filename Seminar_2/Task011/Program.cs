// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine(number);

int digitHundreds = number / 100;
int digitHundredsRemaind = number % 100;
int digitTens = digitHundredsRemaind / 10;
int digitOnes = digitHundredsRemaind % 10;

Console.WriteLine(digitHundreds * 10 + digitOnes);
