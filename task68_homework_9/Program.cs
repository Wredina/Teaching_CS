// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29


int AkkermanFunction(int numOne, int numTwo)
{
 if (numOne == 0) return numTwo + 1;
 else if ((numOne != 0) && (numTwo == 0)) return AkkermanFunction(numOne - 1, 1);
 return AkkermanFunction(numOne - 1, AkkermanFunction(numOne, numTwo - 1));
}

int userNumOne = new Random().Next(1, 4);
int userNumTwo = new Random().Next(1, 4);
System.Console.WriteLine($"{userNumOne}, {userNumTwo}");
if (userNumOne < 0 || userNumTwo < 0) System.Console.WriteLine("введите положительные числа");
else
{
 int akk = AkkermanFunction(userNumOne, userNumTwo);
 System.Console.WriteLine(akk);
}