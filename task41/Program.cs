// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {num} конвертировали в двоичное");

string numDouble = String.Empty;
string numDoubleRev = String.Empty;
while (true)
{
    int res = num%2;
    numDouble = res + numDouble;
    num/=2;
    if(num==0) break;
}
Console.Write(numDouble);