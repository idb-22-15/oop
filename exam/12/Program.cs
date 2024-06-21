using System;
using app.Db;
using app.Models;
using Microsoft.EntityFrameworkCore;


// namespace app
// {
//   public class KeyValue
//   {
//     public int Id { get; set; }
//     public required string Value { get; set; }
//   }

//   public class AppDbContext : DbContext
//   {
//     public DbSet<KeyValue> KeyValues { get; set; }

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//       optionsBuilder.UseSqlite("Data Source=sqlite.db");
//     }
//   }
// }

namespace app
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var context = new AppDbContext())
      {
        // Добавление новой записи
        var keyValue = new KeyValue { Value = "Hello, World!" };
        context.KeyValues.Add(keyValue);
        context.SaveChanges();

        // Извлечение и вывод данных
        foreach (var kv in context.KeyValues)
        {
          Console.WriteLine($"Id: {kv.Id}, Value: {kv.Value}");
        }
      }
    }
  }
}