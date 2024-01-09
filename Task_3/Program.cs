// Задайте произвольный массив.
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Random rand = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = rand.Next(1, 100); // заполнение массива случайными числами от 1 до 100
}

Console.WriteLine("Начальный массив:");
PrintArray(array, 0); // вывод начального массива
Console.WriteLine("\nМассив, выведенный с конца:");
PrintArrayReverse(array, size - 1); // вывод массива, начиная с конца


static void PrintArray(int[] array, int index)
{
    if (index < array.Length)
    {
        Console.Write(array[index] + " ");
        PrintArray(array, index + 1); // рекурсивный вызов для вывода следующего элемента массива
    }
}

static void PrintArrayReverse(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        PrintArrayReverse(array, index - 1); // рекурсивный вызов для вывода предыдущего элемента массива
    }
}