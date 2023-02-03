// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] UserArr(int size)
{
 int[] array = new int[size];
 for (int i = 0; i < size; i++)
 {
  Console.WriteLine($"введите {i + 1} число: ");
  array[i] = Convert.ToInt32(Console.ReadLine());
 }
 return array;
}

int PositiveNum(int[] arr)
{
 int positive = 0;
 for (int i = 0; i < arr.Length; i++)
 {
  if (arr[i] > 0) positive++;
 }
 return positive;
}

Console.WriteLine("введите желательное кол-во чисел: ");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] userArray = UserArr(userSize);
Console.WriteLine($"ваши числа: {String.Join(", ", userArray)}");
int positNum = PositiveNum(userArray);
Console.WriteLine($"кол-во чисел больше нуля = {positNum}");
