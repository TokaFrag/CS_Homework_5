// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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
    int count = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = CreateArray(10, 100, 999);
Print($"{PrintArr(array)}");
int count = FindCount(array);
Print($"The number of even numbers in the array is {count}");
