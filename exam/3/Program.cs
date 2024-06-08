using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = GenerateRandomArray(size);
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(array);

        double median = CalculateMedian(array);
        Console.WriteLine($"Медианное значение массива: {median}");
    }

    // Метод для генерации массива с случайными числами от 0 до size-1
    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(size); // Случайные числа от 0 до size-1
        }
        return array;
    }

    // Метод для вывода массива на экран
    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // Метод для вычисления медианы массива
    static double CalculateMedian(int[] array)
    {
        Array.Sort(array); // Сортируем массив
        int size = array.Length;
        if (size % 2 == 0)
        {
            // Если количество элементов четное, медиана - среднее значение двух центральных элементов
            return (array[size / 2 - 1] + array[size / 2]) / 2.0;
        }
        else
        {
            // Если количество элементов нечетное, медиана - среднее значение центрального элемента
            return array[size / 2];
        }
    }
}