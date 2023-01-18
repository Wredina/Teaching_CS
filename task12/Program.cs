// 12.Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Del(int one, int two)
{
  if (one % two == 0)
  {
    int result = 0;
    return result;
  }
  else
  {
    int result = one % two;
    return result;
  }
}

Console.WriteLine("Введите случайное число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите случайное число 2");
int num2 = Convert.ToInt32(Console.ReadLine());

int final = Del(num1, num2);

if (final == 0)
{
  Console.WriteLine($"число {num1} кратно числу {num2}");
}
else
{
  Console.WriteLine($"число {num1} не кратно числу {num2}, остаток {final}");
}
