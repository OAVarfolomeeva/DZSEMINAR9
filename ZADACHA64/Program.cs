﻿// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
Console.WriteLine(Number(n, m));

int Number(int n, int m)
{
    if (n == m)
    {
        return n;
    }
    else
    {
        Console.Write($"{Number(n, m + 1)}, ");
        return m;
    }
}
