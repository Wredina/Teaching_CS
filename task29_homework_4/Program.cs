// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

int[] GenerateArr(int index)
{
  int[] arr = new int[index];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next();
  }
  return arr;
}

// void PrintArr(int[] arrNum)
// {
//   for (int i = 0; i < arrNum.Length; i++)
//   {
//     Console.Write(arrNum[i] + " ");
//   }
// }

int[] array = GenerateArr(8);
// PrintArr(array);
Console.WriteLine($"{String.Join(", ", array)} ---> [{String.Join(", ", array)}]");