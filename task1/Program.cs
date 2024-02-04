// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void ShowNumbers (int start, int finish)
{
    if (start == finish)
    {
        Console.Write(start);
        return;
    }
    Console.Write(start + " ");
    ShowNumbers(start + 1, finish);
}

Console.Write("Введите начальное число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int last = Convert.ToInt32(Console.ReadLine());

if (first > last)
{
    int change = first;
    first = last;
    last = change;
}

Console.WriteLine("Ряд чисел между ними выглядит так: ");
ShowNumbers(first, last);