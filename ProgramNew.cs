/* Задача 10: 
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

 //int n = new Random().Next(1, 100000);
/* int n = 6540;
int s = ( n % 1000)/100;
Console.WriteLine(n);
if ( s > 0) 
{
    Console.WriteLine(s);
}
else
{
    Console.WriteLine("нет числа");
} */
 
 //________________________________________________________________

 /* Задача 15: 
 Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
 и проверяет, является ли этот день выходным. 
 Обязательна проверка на ввод числа <1 и >8

6 -> да
7 -> да
1 -> нет 
*/

//int den = new Random().Next(1, 8);
/* Console.WriteLine("Ввидите число");
int den = int.Parse(Console.ReadLine()!);
if (den == 1){Console.WriteLine("Пон");}
if (den == 2){Console.WriteLine("Вто");}
if (den == 3){Console.WriteLine("Ср");}
if (den == 4){Console.WriteLine("Чет");}
if (den == 5){Console.WriteLine("Пят");}
if (den == 6){Console.WriteLine("Суб");}
if (den == 7){Console.WriteLine("Вос");}
if (den == 8){Console.WriteLine("похмелье");} 
else
{
    Console.WriteLine("Проверте  число, должно быть от 1 до 7 ");
} */

//______________________________________________
/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).
14212 -> нет
12821 -> да
23432 -> да
*/

/* Console.WriteLine("Введите число: ");
string sum = Console.ReadLine();
int len = sum.Length;

if (len == 5)
{
    if (sum[0] == sum[4] && sum[1] == sum[3])
    {
        Console.WriteLine($"{sum} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{sum} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {sum} - не является пятизначным");
}    
 */
//__________________________________________________________
/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
 */
 /* int[] mas = {3, 6, 8, 2, 1 ,-7};
//int[] mas = {7, -5, 0, 1, -1, 9};

double masR = Math.Sqrt(Math.Pow(mas[0]-mas[2]-mas[4] , 3) + Math.Pow(mas[1]-mas[3]-mas[5], 3));
Console.WriteLine($"{masR:f2}"); */

//______________________________________________________
/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 
*/

/* Console.WriteLine("Введи число:");
int num = int.Parse(Console.ReadLine()!);
if (num < 0)
{
    Console.WriteLine("Число отрицательно преобразовано в положительное");
    num = -num;
}
for (int i = 1; i <= num; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
 */
//___________________________________________ Задача 25:________________________________________________
 /* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
 и возводит число A в натуральную степень B. 
 (Задачи, решенные через Math.Pow, будут отправлены на переделку, 
 так как задача стоит в том, чтобы написать цикл)
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
//----------------------------------------------------------------------------
/* Console.Write("Видите число A:  ");         Так решать нельзя
double a = int.Parse(Console.ReadLine()!);     Так решать нельзя
Console.Write("Видите число B:  ");            Так решать нельзя
double b = int.Parse(Console.ReadLine()!);     Так решать нельзя
double sum = Math.Pow(a, b);                   Так решать нельзя
Console.WriteLine(sum); */                // Нужно через  цикл!!!!!!!!!!

//----------------------Нужно через  цикл!!!!!!!!!!---------------------------------------------

/* Console.Write("Видите число A:  ");         
int a = int.Parse(Console.ReadLine()!);     
Console.Write("Видите число B:  ");            
int b = int.Parse(Console.ReadLine()!);

int count = a;
for (int i = 1; i < b; i++)
{
    count = count * a;
}
Console.WriteLine("Ответ 'А' в степене 'В' ровна: " +count);
 */

//__________________________________________Задача 27:___________________________________________________
/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
 */
/* Console.Write("Ввидите число:  ");
int num = int.Parse(Console.ReadLine()!);
int GetSize(int number)
{
    int i = 10;
    int size = 1;
    while(true)
    {
        if(number / i != 0)
        {
            size += 1;
        }
        else
        {
            break;
        }
         i *= 10;    
    }
    return(size);
} 
Console.WriteLine(GetSize(num)); */


//_________________________________________Задача 29:_____________________________________________________
/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые) */

/* int[] array = GetArray(8);
Console.WriteLine($"[{String.Join(", ", array) }]");

//----------------Метод--------------------------

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] =new Random().Next();
        
    }
    return result;
}
 */


//_________________________________________Задача 34___________________________________________
 /* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2  */
/*
 int size = ReadInt("Введите размерность массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}
if (result % 10 == 1)
{
    Console.WriteLine($"В массиве {result} четное число");
}
if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
    Console.WriteLine($"В массиве {result} четных числа");
}
else

    Console.WriteLine($"В массиве {result} четных чисел");

//--------------------Методы-------------------------------
void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
    }
}

void PrintArray(int[] array) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)  //Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} */

//_________________________________Задача 36_____________________________________________

/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
(индексы элементов должны быть нечетными(1,3,5 и тд)
[3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0 */

/* int size = ReadInt("Введите размерность массива: ");
int min = ReadInt("Введите минимальное число массива: ");
int max = ReadInt("Введите максимальное число массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        result += numbers[i];
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");

// ---------------------------Методы---------------------------------------------
void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)  //Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 
 */
 //____________________________Задача 37_________________________________
 /*  Найдите произведение пар чисел в одномерном массиве. 
 Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
 Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3   [6 7 3 6] -> 36 21 */

Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
int[] array2 = new int[size];
Console.WriteLine(" ");
PrintArray(array);
MultiplyPairs(array);
Console.WriteLine(" ");
PrintArray2(array2);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i] + " "}");
    }
}

void MultiplyPairs(int[] аrray)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        array2[i] = array[i] * array[array.Length - i - 1];
    }
}

void PrintArray2(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i] + " "} ");
        
    }
}
//_____________________________________Задача 38________________________________
// Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементами массива.
/* 
int size = ReadInt("Введите размерность массива: ");
int min = -10; //ReadInt("Введите минимальное число массива: ");
int max = 10;  //ReadInt("Введите максимальное число массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int maxFillarray = numbers[0];
int minFillarray = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxFillarray)
    {
        maxFillarray = numbers[i];
    }
    if (numbers[i] < minFillarray)
    {
        minFillarray = numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillarray - minFillarray}");


// ---------------------------------------Методы--------------------------------------
void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)  //Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} */

//______________________________________Задача 41:_____________________________________________
/*  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2     
1, -7, 567, 89, 223-> 4 */

/* Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}"); */

//________________________* Задача 43:_________________________
/* Написать программу, которая на вход принимает массив из любого количества элементов 
(не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный 
по возрастанию(от меньшего числа к большему). */

/*  int[] array = GetArrayRandom(10, 0, 100);
Console.WriteLine($"Вывод массива в строку: [ {String.Join(", ", array)} ]");
Console.WriteLine($"Сортировка по возрастанию: [ {String.Join(", ", SotrArray(array))} ]");

int[] SotrArray(int[] array)
{
    int tempVar=0;
    bool flag=true;
    while (flag)
    {
        flag=false;
        for (int j = 0; j < array.Length-1; j++)
        {
            if (array[j] > array[j + 1])
            {
                tempVar = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tempVar;
                flag = true;
            }
        }
    }
    return array;
}

int[] GetArrayRandom(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}  */

//____________________________________* Задача 47._____________________________________ 
/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

/* Console.WriteLine("Введите количество строк  ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
 */

//____________________________________* Задача 50._____________________________________ 
/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 5; j = 2 -> такого числа в массиве нет
i = 1; j = 1 -> 9 */

/* int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[6, 8];
FillArray2D(numbers);
PrintArray2D(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} */

//____________________________________* Задача 52._____________________________________ 
/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

/* Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("---------------------------");
Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} ");    
}
Console.ReadLine(); */