// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
  double[] array = new double[size];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Math.Round(rnd.NextDouble() * ((max + 1) - min) + min, 1);
  }
  return array;
}

double MaxMinSub(double[] array)
{
  double max = array[0];
  double min = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (max < array[i]) max = array[i];
    if (min > array[i]) min = array[i];
  }
  return Math.Round(max - min, 1);
}

double[] arr = CreateArrayRndInt(5, 0, 100);
double sub = MaxMinSub(arr);
Console.WriteLine($"[{String.Join(", ", arr)}] -> {sub}");