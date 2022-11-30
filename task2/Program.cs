// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер дня недели ");
int a = int.Parse(Console.ReadLine());

if(a == 3)
{
    Console.WriteLine("Среда");
}

if(a == 5)
{
    Console.WriteLine("Пятница");
}