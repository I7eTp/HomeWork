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

 