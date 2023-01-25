// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("введите число");
int userNum = Convert.ToInt32(Console.ReadLine());

if (userNum < -1)
{
  Console.WriteLine("ввели отрицательное число");
}

int result = Factorial(userNum);
Console.WriteLine($"факториал числа {userNum} = {result}");

int Factorial(int num)
{
  if (num == 0 || num == 1)
  {
    return 1;
  }
  else
  {
    return num * (Factorial(num - 1));
  }
}
