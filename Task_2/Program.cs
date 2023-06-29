// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным вещественным элементом массива.


string PrintArr(double[] array)
{
    return string.Join(", ", array);
}

void Print(string text)
{
    Console.WriteLine(text);
}

double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.NextDouble() + random.Next(min, max);
    }
    return array;
}

double[] GetFraction(double[] array, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = Math.Round(array[i] - Math.Truncate(array[i]), random.Next(min, max));
    }
    return array;
}

double FindDifference(double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];
    double difference = 0;
    foreach (double el in array)
    {
        if (el > maxNumber)
        {
            maxNumber = el;
        }
        if (el < minNumber)
        {
            minNumber = el;
        }
    }
    difference = maxNumber - minNumber;
    return difference;
}

double[] arr = CreateArray(10, 1, 10);
double[] arrFraction = GetFraction(arr, 1, 5);
Print($"Our array of real numbers [{PrintArr(arrFraction)}]");
double difference = FindDifference(arrFraction);
Print($"The difference between the maximum and minimum real number is {difference}");
