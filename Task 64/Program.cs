﻿// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

string NumbersRec(int n, int m)
{
    if (n <= m) return $"{n} " + NumbersRec(n + 1, m);
    else return string.Empty;
}
Console.WriteLine(NumbersRec(4, 8));