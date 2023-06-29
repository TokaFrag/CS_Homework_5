// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

string PrintArr(int[] array)
{
    return string.Join(", ", array);
}

void Print(string text)
{
    Console.WriteLine(text);
}

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int FindCount(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = CreateArray(4, 1, 99);
Print($"{PrintArr(array)}");
int sum = FindCount(array);
Print($"The sum of the elements standing in odd positions {sum}");