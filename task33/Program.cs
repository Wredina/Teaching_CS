﻿// Задача 33: Задайте массив.Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив[6, 7, 19, 345, 3]->нет
// 3; массив[6, 7, 19, 345, 3]->да

int[] CreateArrayRndInt(int size, int min, int max)
{
  int[] array = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(min, max + 1);
  }
  return array;
}

bool Search(int[] array, int find)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == find) return true;
  }
  return false;
}

int[] arr = CreateArrayRndInt(20, 0, 20);
Console.WriteLine(String.Join(", ", arr));

int searchNum = new Random().Next(0, 20);
Console.WriteLine($"ищем {searchNum}");

string findNum = Search(arr, searchNum) ? "yes" : "no";
Console.Write(findNum);