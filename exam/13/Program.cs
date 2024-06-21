using System;
using System.Diagnostics;
using app.Db;
using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var context = new AppDbContext())
      {
        context.Database.EnsureCreated();

        var random = new Random();
        for (int i = 1; i <= 1_000_000; i++)
        {
          context.KeyValues.Add(new KeyValue { Value = $"Value {i}" });
        }
        context.SaveChanges();

        // Измерение времени поиска по ключу
        var sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < 1000; i++)
        {
          int key = random.Next(1, 1_000_001);
          var record = context.KeyValues.Find(key);
        }
        sw.Stop();
        var averageTimeKey = sw.ElapsedMilliseconds / 1000.0;
        Console.WriteLine($"Среднее время поиска по ключу: {averageTimeKey} мс");

        // Измерение времени поиска по значению
        sw.Restart();
        for (int i = 0; i < 1000; i++)
        {
          string value = $"Value {random.Next(1, 1_000_001)}";
          var record = context.KeyValues.FirstOrDefault(kv => kv.Value == value);
        }
        sw.Stop();
        var averageTimeValue = sw.ElapsedMilliseconds / 1000.0;
        Console.WriteLine($"Среднее время поиска по значению: {averageTimeValue} мс");
      }
    }
  }
}