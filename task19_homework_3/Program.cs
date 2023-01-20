// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.WriteLine($"Введите пятизначное число");
int userNum = Convert.ToInt32(Console.ReadLine());
int result = 0;

int ConvNum(int num)
{
  for (int i = 0; i < 5; i++)
  {
    result = result * 10 + num % 10;
    num = num / 10;
  }
  return result;
}

if (userNum >= 100000 || userNum < 10000)
{
  Console.WriteLine("вы ввели не верное число");
}
else if (ConvNum(userNum) == userNum)
{
  Console.WriteLine($"{userNum} является палиндромом");
}
else
{
  Console.WriteLine($"{userNum} не является палиндромом");
}