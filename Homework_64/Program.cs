// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

using System;
using static System.Console;

Write("Введите натуральное целое число M: ");
int m = int.Parse(ReadLine());
Write("Введите натуральное целое число N: ");
int n = int.Parse(ReadLine());

for (int i = m; i<=n; i++)
{
    Write($"{i} ");
}