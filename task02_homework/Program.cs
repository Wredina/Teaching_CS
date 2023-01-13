// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

Console.WriteLine("введите первое число");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int numTwo = Convert.ToInt32(Console.ReadLine());

if (numOne > numTwo)
{
  Console.WriteLine($"Максимальное число = {numOne}, минимальное число = {numTwo}");
}
else if (numTwo > numOne)
{
  Console.WriteLine($"Максимальное число = {numTwo} минимальное число = {numOne}");
}
else
{
  Console.WriteLine($"Чсло {numOne} равно числу {numTwo}");
}