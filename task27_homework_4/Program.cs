// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452-> 11
// 82-> 10
// 9012-> 12

int Sum(int num)
{
  int result = 0;
  for (int i = 0; num != 0; i++)
  {
    result += num % 10;
    num /= 10;
  }
  return result;
}

Console.WriteLine("Введите число");
int userNum = Convert.ToInt32(Console.ReadLine());

int sum = Sum(userNum);
Console.WriteLine($"сумма чисел {userNum} = {sum}");