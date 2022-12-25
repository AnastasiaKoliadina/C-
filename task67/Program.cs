﻿// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8


int GetSumNumb(int a)
{
    if (a > 0) a = a % 10 + GetSumNumb(a / 10);
    return (a);
}
Console.WriteLine("Введите число a: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write(GetSumNumb(n));
