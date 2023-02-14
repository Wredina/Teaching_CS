// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8


int MulNum(int numOne, int numTwo)
{
  if (numTwo == 0 || numOne == 0) return 1;
  if (numOne >= numTwo) return numTwo * MulNum(numOne - 1, numTwo);
  else return numOne * MulNum(numOne, numTwo - 1);
}



int userNumOne = new Random().Next(1, 10);
System.Console.Write($"{userNumOne}, ");
int userNumTwo = new Random().Next(1, 10);
System.Console.WriteLine(userNumTwo);
int mulNum = MulNum(userNumOne, userNumTwo);
System.Console.WriteLine(mulNum);