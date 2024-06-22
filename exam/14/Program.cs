using app.Db;
using app.Models;
using Microsoft.EntityFrameworkCore;

class Program
{

	static void FillDb(AppDbContext db)
	{
		var random = new Random();
		for (int i = 1; i < 31; i++)
		{
			db.Group.Add(new Group { Title = $"Group {i}" });
		}
		for (int i = 0; i <= 100; i++)
		{
			db.Item.Add(new Item { GroupId = random.Next(1, 31), IsOk = Convert.ToBoolean(random.Next(0, 2)) });
		}
		db.SaveChanges();
	}

	static void PrintDb(AppDbContext db)
	{
		var groups = db.Group.ToList();
		foreach (var group in groups)
		{
			Console.WriteLine($"{group.Title}");

			foreach (var item in group.Items)
			{
				Console.WriteLine($"  Item: {item.Id}, IsOk: {item.IsOk}");
			}

			Console.WriteLine();
		}
	}
	// 
	static void Main(string[] args)
	{
		using var db = new AppDbContext();
		db.Database.EnsureDeleted();
		db.Database.EnsureCreated();
		FillDb(db);
		PrintDb(db);
	}
}