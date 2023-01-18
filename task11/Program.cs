// 11.Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(99, 1000);
Console.WriteLine($"Случайное трёхзначное число {number}");

int Dell(int num)
{
  int numFirst = num / 100;
  int lastNum = num % 10;

  int result = numFirst * 10 + lastNum;
  return result;
}

int twoNum = Dell(number);
Console.WriteLine($"первое и второе число вместе = {twoNum}");