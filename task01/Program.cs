// 1.Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5->да
// a = 2, b = 10->нет
// a = 9, b = -3->да
// a = -3 b = 9 -> нет


Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
  if (numA / numB == numB)
  {
    Console.WriteLine("Первое число является квадратом второго");
  }
  else
  {
    Console.WriteLine("Первое число не является квадратом второго");
  }
}
else
{
  if (numB / numA == numA)
  {
    Console.WriteLine("Второе число является квадратом первого");
  }
  else
  {
    Console.WriteLine("Второе число не является квадратом первого");
  }
}

