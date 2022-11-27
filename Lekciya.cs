//------------------------метод нечего не принимает только отдает---------------------------
/* void Method1()
{
Console.WriteLine(" Автор");
}
Method1();
 */
//----------------------метод не чего не возращает но имеет аргумент-----------------------

/* void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения"); */

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");    метод закоментирован

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        count++;
    }
}
Method21("Текст, 4");

