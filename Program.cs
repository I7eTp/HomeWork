﻿/*Задача 2: 
Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.WriteLine("Видите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Видите второе число");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine("Первое число больше");
}
else
{
    Console.WriteLine("Второе число больше");
}
*/

/*Задача 4: 
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
Console.WriteLine("Видите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Видите второе число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Видите третье число");
int c = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine("Первое число больше");
}
if (b > c)
{
    Console.WriteLine("Второе число больше");
}
else
{
    Console.WriteLine("Третье число больше");
}
*/

/*Задача 6: 
Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
Пример: Число % 2 == 0 - четное
4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.WriteLine("Видите одно число");
int n = int.Parse(Console.ReadLine()!);
if (n % 2 == 0)
{
    Console.WriteLine("Чётное число");
}
else
{
    Console.WriteLine("Нечётное больше");
}
*/
/*Задача 8: 
Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Видите одно число  ");
int n = int.Parse(Console.ReadLine());
    
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);
