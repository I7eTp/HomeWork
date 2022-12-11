/*Задача 2: 
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
/*
Console.Write("Видите одно число  ");
int n = int.Parse(Console.ReadLine());
    
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);
*/
//Напишем программу которая ввыводит числа и 
//456 -> 46
/* int number = new Random().Next(100, 1000);
Console.WriteLine(number);
Console.WriteLine($"Число без втой цифры имеет вид: {number/100}{number%10}");
Console.WriteLine();
int result = (number/100)*10 + (number%10);
Console.WriteLine(result);  */

/* Console.WriteLine("Ввиди трехзначное число   ");
string Numbers + Console.ReadLine()!;
 */
/* if(Numbers.Length != 3)
{
    Console.WriteLine("Виден не правелное число");

}
else
{
    Console.WriteLine($"Число без вторых данных имеет вид: {Numbers[0]}{Numbers[2]}");
} */

/* **Задача 9.**
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/
/* int number =new Random().Next(10, 100);
Console.WriteLine(number);
if(number/10 > number%10)
{
    Console.WriteLine(number/10);
}
else
{
    Console.WriteLine(number%10);
}
 */

/* **Задача 12:** 
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4  -> кратно
 */

 //____________________________________________________________
 /*Напишите программу, которая по задоному номеру четверти, 
 показывает диапозон возможных кординат точек в этой четверти (х и у)*/

 /* Console.WriteLine("Ввидите № четверти:  ");
 int number = int.Parse(Console.ReadLine()!);

 switch (number){case 1:{Console.WriteLine("Это первая четверть!"); break;} case 2:{Console.WriteLine("Это вторая четверть!"); break;}
    case 3:
    {
        Console.WriteLine("Это третья четверть!");
        break;
    }
    case 4:
    {
       Console.WriteLine("Это четвертая четверть!");
        break; 
    }
    default:
    {
        Console.WriteLine("Такой четверти нет");
        break; 
    }
 } */
 //___________________________Урок 4_____________________________

 //напишем число  на воде число А и выдает сумму чисел от 1 до А.
/* Console.WriteLine("Видите сумму");
int A = int.Parse(Console>ReadLine()!);
Console.WriteLine($"Сумма числ от 1 до {A} буд рав {GetSum(A)}");



 //----------------------методы----------------------------------
int GetSum(int limit)
{
    int sim=0;
    for(int i = 1; i <=limit; i++)
    {
        GetSum = sum + i; // sum +=i

    }
    return sum;
} */

// ______________________________Задача 17:________________________________________________ 
/*Определить, является ли заданное шестизначное число счастливым. 
(Счастливым называют такое шестизначное число, 
что сумма его первых трех цифр равна сумме его последних трех цифр).
 */ 
 /* int loto = new Random().Next(100000, 999999);
Console.WriteLine(loto);
//int loto = 333333;
int sum1 = loto/1000;
int sum2 = loto - sum1*1000;

Console.WriteLine(sum1);
Console.WriteLine(sum2);
if(sum1 == sum2)
{
    Console.WriteLine("Бинго");
}
else{
    Console.WriteLine("пробуй заново");
}  */
//_________________________Задача 19__________________________________________________

/* Напишите программу, которая принимает на вход координаты двух точек. 
И находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/
/* int[] mas = {3, 6, 2, 1};
//int[] mas = {7, -5, 1, -1};

double masR = Math.Sqrt(Math.Pow(mas[0]-mas[2], 2) + Math.Pow(mas[1]-mas[3], 2));
Console.WriteLine($"{masR:f2}"); */


//_________________________Задача 21__________________________________________________
/*  Напишите программу, которая принимает на вход число (N) 
 и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1, 4
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
        Console.Write($"{Math.Pow(i, 2)} ");
    } */
    
//__________________________________**Задача 26:**________________________________________________________
/* 
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

 /* Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В числе {NumOfDigits(number)} цифр");
//-----------------------------------------------Методы---------------------------------------------------------//
int NumOfDigits(int count)
{
    int i = 1;
    int j = 0;
    while (i<count)
    {
        count = count/10;
        j++;
    }
    return j;
}  */
//__________________________________**Задача 26: другой вариант решения________________________________________________________
/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

/* Console.WriteLine(GetLength(88888888));

int GetLength(int num)
{
    int a = 1;
    for (int i = 10; i< 100000000; i *= 10, a++)
    {
        if (num/i > 0 && num/i < 10){
            break;
        }
    }
    return a+1;
} */

//__________________________________**Задача 26: другой вариант решения________________________________________________________
/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

/*  Console.WriteLine("Ввидите число  ");
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

//___________________________Задача 28:__________________________________________
/* 
Найти произведение всех элементов массива целых чисел, меньших заданного числа. 
Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100. 
*/

/* int[] arraySize = FillArray(10);
Console.WriteLine($"{String.Join(",", arraySize)}");
Console.WriteLine("Ввидите число:  ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{sumArray(arraySize, num)}");

int sumArray(int[]array, int num)
{
    int sum = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < num)
        sum *= array[i];
    }
    return sum;    
}

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i< size; i++)
    {
        arr[i] = new Random().Next(50, 100);
    }
    return arr;
} */

//______________________* **Задача 30:**______________________________________________
/* 
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] 
*/
/* int[] array = new int[8];
Mass(array);
Console.WriteLine($"Массив:  {String.Join(" ", array)}");

//-----------------Метод------------------

int[] Mass(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
 */

//______________________* **Задача 30:другой вариант решения______________________________________________
/* 
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] 
*/

/* int[] array = GetArray(8);
Console.WriteLine($"[{String.Join(", ", array) }]");

//----------------Метод--------------------------

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] =new Random().Next(2);
        
    }
    return result;
} */

//____________________________________Задача 31_________________________________________
/* Задайте массив из 12 элем., заполниные случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительны элементов массива
*/

/* 
int[] array = GetArray(12, -9, 9);
Console.WriteLine($"[{String.Join(",", array)}]");

int positiveSum = 0;
int negativeSum = 0;

foreach(int el in array)        //элемент (отрецательный или положительны), и массив из 12 элементов. 
{
    if(el > 0)                  // узнаем (el)-элемент больше или меньще нуля
    {
        positiveSum += el;      //если больше  + positiveSum
    }
    else{
        negativeSum += el;      //если меньше  + negativeSum
    }
}
Console.WriteLine($"Сумма положительных: {positiveSum}, сумма отрицательных: {negativeSum}");

//-------------------------------метод--------------------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0;  i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result; 
} */
//________________________________Задача 32___________________________
/*Напишите программу замены элементов массива: "+" заменить на "-" и наоборот.
[-4, -8, 8, -2] -> [4, 8, -8, 2]
*/
/* int[] array = GetArray(4, -9, 9);
Console.WriteLine($"[ {String.Join(", ", array)} ]");

for(int i=0; i< array.Length; i++){
    array[i] *=-1;
}

Console.WriteLine($"[ {String.Join(", ", array)} ]");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
} */

//__________________________________Задача 33________________________________________
//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
/* int[] array = GetArray(10, -9, 9);
Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

bool rez=false;
for(int i=0; i< array.Length; i++){
    if (array[i] == number) rez=true;
}
if (rez==true) Console.WriteLine ("Да");
else Console.WriteLine ("Нет");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}
 */

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/* 
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
// ------------------Методы-----------------------

// Метод создания двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


// Метод печати двумерного масссива
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
} */


//_____________________________________**Задача 48:**__________________
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.
/* 
m = 3, n = 4.
 0 1 2 3
 1 2 3 4
 2 3 4 5
 */
/*  Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 3, 4);     //(rows, columns, 0, 10)
PrintArray(array);
// ------------------Методы-----------------------

// Метод создания двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


// Метод печати двумерного масссива
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
} 
 */

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//  m = 3, n = 4.    
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
//////////////////////////////////////////////////////////////////////////////////////////
// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

/* 
Console.Write("Введите кол-во сток:");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов:");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArrayRandom(rows,columns,0,10);
PrintArray(array);
GetArrayMethod(array);
Console.WriteLine("====================");
PrintArray(array);
GetDiag(array);

int[,] GetArrayRandom(int sizeM, int sizeN, int minValue, int maxValue)
{
    int[,] array = new int[sizeM, sizeN];
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            // array[i, j]=i+j;
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[") ;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  {array[i, j]}") ;
        }
         Console.WriteLine("  ]") ;
    }
}

void GetArrayMethod(int[,] array){
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i%2==0 && j%2==0) array[i,j]=(int)Math.Pow(array[i,j],2) ;
        }
    }
}

void GetDiag(int[,] array){
int sum =0;
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i==j){
                Console.Write($"{array[i,j]} + ");
                sum=sum+array[i,j];
            }
        }
    }
     Console.WriteLine($"Сумма = {sum}");
}
 */
// ________________________Задача 63:___________________________
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

/* Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNumbers(1,N));

string PrintNumbers(int start, int end)
{
    if(start == end) return start.ToString();
    return(start + " " + PrintNumbers(start + 1, end));
}
 */
//______________________________________ Задача 65:______________________________
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
/* / Console.Write("введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNumber(m,n));

string PrintNumber(int start, int end)
{
    if (start==end) return start.ToString();
    return(start + " " + PrintNumber(start + 1, end));
}  */
//____________________________________ Задача 67:_________________________________________
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
/* Console.Write("введите число N: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNumber(number));

int SumNumber(int num)
{
    if (num==0) return 0;
    return (num%10 + SumNumber(num/10));
} */
//____________________________________ Задача 69:__________________________________________
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
/* Console.Write("введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(DegreeNumber(A,B));

int DegreeNumber(int A, int B)
{
    if(B==0)return 1;
    if (B == 1) return A;
    return (A * DegreeNumber(A,B-1));
} */




 