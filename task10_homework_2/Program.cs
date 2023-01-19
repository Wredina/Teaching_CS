// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int NumTwo(int num)
{
  int del = num / 10;
  return del % 10;
}

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число {number}");

int result = NumTwo(number);
Console.WriteLine($"Из трёхначного числа {number} вторая цифра = {result}");

