//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
//от 1 до N.
//
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int num = 1;
Console.WriteLine($"Таблица квадратов числа {N} от 1 до {N}");
while ( num <= N )
{
   double result = num * num;
   Console.WriteLine(result);
   num ++;

}