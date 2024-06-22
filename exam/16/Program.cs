using System.Diagnostics;

class Program
{
  static readonly object lockObject = new();
  static readonly int[] waitTimes = new int[10];

  static void Main(string[] args)
  {
    int numThreads = 10;
    Thread[] threads = new Thread[numThreads];

    for (int i = 0; i < numThreads; i++)
    {
      int threadIndex = i;
      threads[i] = new Thread(() =>
      {
        var random = new Random();
        int x = random.Next(0, 1001);
        int arraySize = random.Next(10000000, 15000001);
        int[] array = GenerateRandomArray(arraySize, 0, 1000);
        Array.Sort(array);

        var watch = Stopwatch.StartNew();
        bool acquired = false;
        while (!acquired)
        {
          try
          {
            Monitor.TryEnter(lockObject, ref acquired);
          }
          catch (ThreadInterruptedException)
          {
          }
        }
        watch.Stop();
        waitTimes[threadIndex] = (int)watch.ElapsedMilliseconds;

        int count = CountElementsEqualToX(array, x);
        Monitor.Exit(lockObject);

        Console.WriteLine($"Поток {threadIndex + 1}: Количество элементов, равных {x}: {count}. Время ожидания: {waitTimes[threadIndex]} мс");
      });
      threads[i].Start();
    }

    foreach (Thread thread in threads)
    {
      thread.Join();
    }

    int minWaitTime = waitTimes.Where(t => t > 0).Min();
    int maxWaitTime = waitTimes.Max();
    int avgWaitTime = (int)waitTimes.Where(t => t > 0).Average();

    Console.WriteLine($"Минимальное время ожидания: {minWaitTime} мс");
    Console.WriteLine($"Максимальное время ожидания: {maxWaitTime} мс");
    Console.WriteLine($"Среднее время ожидания: {avgWaitTime} мс");
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
      else if (array[i] > x)
      {
        break;
      }
    }
    return count;
  }
}
