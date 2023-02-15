// // Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int SumUserNum(int numOne, int numTwo)
{
 if (numOne == numTwo) return numOne;
 else if (numOne > numTwo)
 {
  return numOne + SumUserNum(numOne - 1, numTwo);
 }
 else
 {
  return numTwo + SumUserNum(numOne, numTwo - 1);
 }
}

// я понимаю, что вводить должен юзер, но в процессе обучения мне удобнее использовать рандом
// system я использую для быстроты печати кода через cw - система сама выводит так
// и большинство онлайн компиляторов по с# не распознают Console.WriteLine без system, а мне частенько приходится там писать
int userNumOne = new Random().Next(1, 10);
int userNumTwo = new Random().Next(1, 10);
System.Console.WriteLine($"{userNumOne}, {userNumTwo}");
int sumUserNum = SumUserNum(userNumOne, userNumTwo);
System.Console.WriteLine(sumUserNum);