// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] GenerateArr(int index, int min, int max)
{
  // Random rnd = new Random; - запихнуть метод рандом в переменную
  int[] arr = new int[index];
  for (int i = 0; i < arr.Length; i++)
  {
    // arr[i] = rnd.Next(min, max + 1); - использование переменной с методом рандом внутри
    arr[i] = new Random().Next(min, max + 1);
  }
  return arr;
}

void PrintArr(int[] arrNum)
{
  for (int i = 0; i < arrNum.Length; i++)
  {
    Console.Write(arrNum[i]);
  }
}

int[] array = GenerateArr(8, 0, 1);
PrintArr(array);