// Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// *можно выполнить через вычленение остатка %2
// есть предложение выполнения через рекурсию

int Binar(int num)
{
 int bin = 0;
 int count = 1;
 while (num != 0)
 {
  bin += num % 2 * count;
  num /= 2;
  count *= 10;
 }
 return bin;
}

int result = Binar(45);
Console.WriteLine(result);