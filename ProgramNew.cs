﻿/* Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. 
Обязательна проверка на ввод чисел больше/меньше 3-х знаков 
456 -> 5
782 -> 8
918 -> 1
*/

/* int n = new Random().Next(100, 1000);
int s = ( n % 100) / 10;
Console.WriteLine(n);
Console.WriteLine(s); */
//____________________________________________________________

/* Задача 13: 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. Берем числа до 100000
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/* int n = new Random().Next(1, 100000);
int s = ( n % 1000)/100;
Console.WriteLine(n);
if ( s > 0) 
{
    Console.WriteLine(s);
}
else
{
    Console.WriteLine("нет числа");
}
 */
 //________________________________________________________________

 /* Задача 15: 
 Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
 и проверяет, является ли этот день выходным. 
 Обязательна проверка на ввод числа <1 и >8

6 -> да
7 -> да
1 -> нет 
*/

/* int den = new Random().Next(1, 8);
if (den == 1){Console.WriteLine("Пон");}
if (den == 2){Console.WriteLine("Вто");}
if (den == 3){Console.WriteLine("Ср");}
if (den == 4){Console.WriteLine("Чет");}
if (den == 5){Console.WriteLine("Пят");}
if (den == 6){Console.WriteLine("Суб");}
if (den == 7){Console.WriteLine("Вос");}
if (den == 8){Console.WriteLine("похмелье");} */