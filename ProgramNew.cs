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

/* Console.WriteLine("Введите размер массива ");
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
} */
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

// _____________________________________Задача 53:________________________________
/* Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2
Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] arrayFirst = GetArray(rows, columns, 10, 99);
PrintArray(arrayFirst);
Console.WriteLine("=====================");
// SortArray(arrayFirst);
// PrintArray(arrayFirst);
if (arrayFirst.GetLength(0) == arrayFirst.GetLength(1))
{
    int[,] arraySecond = RouteArray(arrayFirst);
    PrintArray(arraySecond);
}
else Console.WriteLine("Матрица не квадратная i<>j");


int[,] GetArray(int rows, int columns, int minValues, int maxValues)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            array[i, j] = new Random().Next(minValues, maxValues + 1);
        }

    }
    return array;
}

void SortArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] RouteArray(int[,] array)
{
    int[,] array2= new int[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[j, i]=array[i,j];
        }
    }
 return array2;
}
*/
//_______________________________________ Задача 55:________________________
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

/* int[,] ArrayTranspons(int[,]array)
{
    if (array.GetLength(0)==array.GetLength(1)){
        int [,] NewArray = new int [array.GetLength(0),array.GetLength(1)];
        for(int i =0; i<array.GetLength(0);i++)
        {
            for( int j=0 ; j < array.GetLength(1); j++)
            {
                NewArray[j,i]=array[i,j];
            }
        }
        return NewArray;
    }
    else 
    {
        Console.WriteLine("конвертация масива невозможна");
    return array;
    }
}
//Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент

int[,] ArrayDell(int[,] array){
    int numbeMin = array[0,0];
    int num1=0 , num2 =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++){
            if (numbeMin>array[i,j])
            { 
                numbeMin=array[i,j];
                num1=i ;
                num2 = j;
            }
        }
    }
    int [,] array2 = new int[array.GetLength(0)-1,array.GetLength(1)-1];
    for (int i = 0 , x = 0 ; i < array.GetLength(0); x++, i++)
    {
        if ( i== num1) {
            x--;
            continue;
        }
        for (int j = 0 , y = 0; j < array.GetLength(1); y++, j++){
            if ( j== num2) {
            y--;
            continue;
            }
            array2[x,y]=array[i,j];
        }
    }
    return array2;
} */
/*________________________________ Задача 54:____________________ 
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

/* int[,] table = new int[3, 4];
FillArrayRandom(table);
PrintArray(table);
SortToLower(table);
Console.WriteLine();
PrintArray(table);


void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

 */

/* _____________________________________Задача 56:_________________________________
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */

/* int[,] table = new int[4, 4];
FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
NumberRowMinSumElements(table);


void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        minRow += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

 */

/* _________________________________Задача 58:_____________________________
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
 */

/* Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
 */
/*___________________________________ Задача 60._________________________
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
 */
/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

Для оценки отлично надо решить 3 любых задачи из 5
Соотвественно, если решите все, то оценка тоже "Отлично"
Решите 2 из 3 оценка Хорошо
Решите 1 из 3 оценка Удовл */