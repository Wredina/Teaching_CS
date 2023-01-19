// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int NumTree(int num)
{
  while (num > 1000)
  {
    num = num / 10;
  }
  return num % 10;
}

Console.WriteLine("Введите случайное число");
int number = Convert.ToInt32(Console.ReadLine());
// int number = new Random().Next(1, 10000000);
// Console.WriteLine($"Случайное число {number}");

if (number < 100)
{
  Console.WriteLine("третьего числа нет");
}
else
{
  int res = NumTree(number);
  Console.WriteLine($"Третье число {res}");
}