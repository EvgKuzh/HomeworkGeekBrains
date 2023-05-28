// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;
using static System.Console;

Write("Введите целое положительное цисло m: ");
int m = int.Parse(ReadLine());
Write("Введите целое положительное цисло n: ");
int n = int.Parse(ReadLine());

Write($"A(m,n) = {Ackermann(m,n)}");

int Ackermann (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return Ackermann(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return Ackermann(numberM - 1, Ackermann(numberM, numberN - 1));
return Ackermann(numberM, numberN);
}