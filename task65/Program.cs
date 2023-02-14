// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 5, 6, 7, 8"

void NaturalNum(int numOne, int numTwo)
{
  System.Console.Write($"{numOne}  ");
  if (numOne == numTwo) return;
  else if (numOne > numTwo)
  {
    NaturalNum(numOne - 1, numTwo);
  }
  else
  {
    NaturalNum(numOne + 1, numTwo);
  }
}

int userNumOne = new Random().Next(1, 10);
System.Console.Write($"{userNumOne}, ");
int userNumTwo = new Random().Next(1, 10);
System.Console.WriteLine(userNumTwo);
NaturalNum(userNumOne, userNumTwo);