// # Дано натуральное число A > 1. Определите, каким по
// # счету числом Фибоначчи оно является, то есть
// # выведите такое число n, что φ(n) = A. Если А не
// # является числом Фибоначчи, выведите число - 1.
// # Input: 5
// # Output: 6
// # 0, 1, 1, 2, 3, 5, 8

System.Console.WriteLine("ввелдите число больше 1: ");
int n = Convert.ToInt32(Console.ReadLine());

int fib1 = 0;
int fib2 = 1;
int fib3 = 0;
int count = 2;
while (fib2 < n)
{
 fib3 = fib1 + fib2;
 fib1 = fib2;
 fib2 = fib3;
 count++;
}

if (n == fib2)
{
 System.Console.WriteLine(count);
}
else
{
 System.Console.WriteLine(-1);
}