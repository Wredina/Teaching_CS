// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи.Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] FibonacciNum(int size)
{
 int[] fibArr = new int[size];
 fibArr[0] = 0;
 fibArr[1] = 1;
 for (int i = 2; i < fibArr.Length; i++)
 {
  fibArr[i] = fibArr[i - 1] + fibArr[i - 2];
 }
 return fibArr;
}

int[] fibonacci = FibonacciNum(7);
Console.WriteLine(String.Join(' ', fibonacci));