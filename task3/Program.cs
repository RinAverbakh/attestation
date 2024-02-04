// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void PrintArrayFromTheEnd (int[] array, int i)
{
    if (i == array.Length - 1)
    {
        Console.Write(array[i] + " ");
        return;
    }
    PrintArrayFromTheEnd(array, i + 1);
    Console.Write(array[i] + " ");
}

int[] numbers = [1, 2, 3, 4, 5];
PrintArrayFromTheEnd(numbers, 0);
