using Microsoft.EntityFrameworkCore;
using app.Models;

namespace app.Db
{
	public class AppDbContext : DbContext
	{
		public AppDbContext()
		{
			Database.EnsureCreated();
		}
		public DbSet<Item> Item { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=sqlite.db");
		}
	}
}
