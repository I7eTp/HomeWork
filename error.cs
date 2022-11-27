//____________________________________Задача 31_________________________________________
/* Задайте массив из 12 элем., заполниные случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительны элементов массива
*/

int[] array = GetArray(12, -9, 9);
Console.WriteLine($"[{String.Join(",", array)}]");

int positive = 0;
int negative = 0;

foreach(int el in array)
{
    if(el > 0)
    {
        positive += el;
    }
    else
    {
        negative += el; 
    }
}
Console.WriteLine("Сумма положительных: {positive}, сумма отрицательных: {negative}");


//-------------------------------метод--------------------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int result = new int[size];
    for(int i = 0;  i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result; 
}
