// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5

int[] CreateArrayRndInt(int size, int min, int max)
{
  int[] array = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(min, max + 1);
  }
  return array;
}

int QuantNum(int[] array, int min, int max)
{
  int num = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > min && array[i] < max + 1) num++;
  }
  return num;
}

int[] arr = CreateArrayRndInt(123, 1, 200);
int quantNum = QuantNum(arr, 10, 99);
Console.WriteLine($"[{String.Join(", ", arr)}] --> {quantNum}");

