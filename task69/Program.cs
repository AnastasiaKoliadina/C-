// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в 
// целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Degree(int a, int b)
{
    if (b == 0) return 1;
    else return a * Degree(a, b - 1);
}
Console.WriteLine("Введите число a: ");
int n = Math.Abs(int.Parse(Console.ReadLine()!));
Console.WriteLine("Введите число b: ");
int m = Math.Abs(int.Parse(Console.ReadLine()!));
Console.WriteLine($"Число {n} в степени {m} равно {Degree(n, m)}");
// Можно и так:
//int Degree(int a, int b)
// {
//     if (b == 0) return 1;
//     else return a * Degree(a, b - 1); // b=3 ; a*   b=2; a* b=1 a*; b=0  1
// }                                     // a*   a*  a* 1                                     
// Console.WriteLine("Введите положительное число a: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите положительное число b: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Число {n} в степени {m} равно {Degree(n, m)}");
