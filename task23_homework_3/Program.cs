// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int userNum = Convert.ToInt32(Console.ReadLine());

void Conv(int num)
{
  if (num < 0)
  {
    for (int i = -1; i >= num; i--)
    {
      double result = Math.Pow(i, 3);
      Console.Write($"{result}, ");
    }
  }
  else
  {
    for (int i = 1; i <= num; i++)
    {
      double result = Math.Pow(i, 3);
      Console.Write($"{result}, ");
    }
  }
}

Conv(userNum);