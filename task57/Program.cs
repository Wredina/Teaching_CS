// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateArray(int rows, int colums, int min, int max)
{
 int[,] array = new int[rows, colums];
 Random rnd = new Random();
 for (int i = 0; i < array.GetLength(0); i++)
 {
  for (int j = 0; j < array.GetLength(1); j++)
  {
   array[i, j] = rnd.Next(min, max);
  }
 }
 return array;
}

void PrintaMatrix(int[,] matrix)
{
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
  Console.Write("[");
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
   if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],3} |"); else System.Console.Write($"{matrix[i, j],3} ]");
  }
  System.Console.WriteLine();
 }
}

int NumArrMatrix(int[,] array)
{
 int result = 0;
 int num = array[0, 0];
 for (int i = 0; i < array.GetLength(0); i++)
 {
  for (int j = 0; j < array.GetLength(1); j++)
  {
   if (num == array[i, j]) result++;
  }
 }
 return result;
}


int[,] arr = CreateArray(4, 4, 0, 30);
PrintaMatrix(arr);
int size = arr.GetLength(0) * arr.GetLength(1);
int count = 0;
while (count < size)
{
 int res = NumArrMatrix(arr);
 if (res == 0) count++;
 else
 {
  System.Console.WriteLine($"в массиве {res} штук");
  count++;
 }
}
