﻿// 14.Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

int Redness(int number)
{
  if (number % 7 == 0 && number % 23 == 0)
  {
    return 1;
  }
  return 0;
}

Console.WriteLine("Введите случайное число");
int num = Convert.ToInt32(Console.ReadLine());

int rednNum = Redness(num);

if (rednNum == 1)
{
  Console.WriteLine($"число {num} кратно 7 и 23 одновременно");
}
else
{
  Console.WriteLine($"число {num} не кратно 7 и 23 одновременно");
}