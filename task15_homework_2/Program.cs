// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool DayOfWeek(int num)
{
  return num == 6 || num == 7;
}

Console.WriteLine("Введите число дня недели от 1 до 7-ми");
int number = Convert.ToInt32(Console.ReadLine());
// int number = new Random().Next(1, 8);
// Console.WriteLine($"Случайное число {number}");

bool res = DayOfWeek(number);
string day = res ? "выходной день" : "будний день";

Console.WriteLine(day);