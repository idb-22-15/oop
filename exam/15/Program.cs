using System;
using System.Threading;
using System.Diagnostics;
class Program
{
  static void Main(string[] args)
  {
    int numThreads = 10;
    int[] executionTimes = new int[numThreads];
    Thread[] threads = new Thread[numThreads];

    for (int i = 0; i < numThreads; i++)
    {
      int threadIndex = i;
      threads[i] = new Thread(() =>
      {
        int targetValue = new Random().Next(0, 1001);
        int arraySize = new Random().Next(10000000, 15000001);
        int[] array = GenerateRandomArray(arraySize, 0, 1001);

        var watch = Stopwatch.StartNew();
        int count = CountElementsEqualToX(array, targetValue);
        watch.Stop();

        executionTimes[threadIndex] = (int)watch.ElapsedMilliseconds;
        Console.WriteLine($"Поток {threadIndex + 1}: Количество элементов, равных {targetValue}: {count}. Время выполнения: {executionTimes[threadIndex]} мс");
      });
      threads[i].Start();

      foreach (Thread thread in threads)
      {
        thread.Join();
      }

      int minTime = executionTimes.Min();
      int maxTime = executionTimes.Max();
      int avgTime = (int)executionTimes.Average();

      Console.WriteLine($"Минимальное время выполнения: {minTime} мс");
      Console.WriteLine($"Максимальное время выполнения: {maxTime} мс");
      Console.WriteLine($"Среднее время выполнения: {avgTime} мс");
    }

    static int[] GenerateRandomArray(int size, int min, int max)
    {
      int[] array = new int[size];
      var random = new Random();
      for (int i = 0; i < size; i++)
      {
        array[i] = random.Next(min, max + 1);
      }
      return array;
    }

    static int CountElementsEqualToX(int[] array, int x)
    {
      int count = 0;
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == x)
        {
          count++;
        }
      }
      return count;
    }
  }
}