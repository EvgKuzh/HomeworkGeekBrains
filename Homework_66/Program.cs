// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using System;
using static System.Console;

Write("Введите целое натуральное число M: ");
int m = int.Parse(ReadLine());
Write("Введите целое натуральное число N: ");
int n = int.Parse(ReadLine());

int summa = 0;
for (int i = m; i<=n; i++)
{
    summa +=i;
}
Write($"Сумма чисел от {m} до {n} = {summa}");
