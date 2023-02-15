// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void NumCicle(int num)
{
 if (num == 0) return;
 if (num > 0)
 {
  System.Console.Write($"{num} ");
  NumCicle(num - 1);
 }
 else
 {
  System.Console.Write($"{num} ");
  NumCicle(num + 1);
 }


}


int userNum = new Random().Next(-10, 10);
System.Console.WriteLine(userNum);
NumCicle(userNum);