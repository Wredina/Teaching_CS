// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// *Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool SumSide(int side1, int side2, int side3)
{
 return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
}

string result = SumSide(4, 3, 7) ? "yes" : "no";
Console.WriteLine(result);