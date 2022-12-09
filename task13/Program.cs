//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5


int CountNum(int num);
{
    int count = 0;
while (num > 0)
{
    num /= 10;
    count++;
}
return count;
}
Console.WriteLine($"Количество цифр в числе {count}");
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());