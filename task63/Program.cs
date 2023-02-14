// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void NaturalNum(int num)
{
  if (num == 0) return;
  NaturalNum(num - 1);
  System.Console.Write($"{num} ");
}

int rndNum = new Random().Next(1, 10);
System.Console.WriteLine(rndNum);
NaturalNum(rndNum);

