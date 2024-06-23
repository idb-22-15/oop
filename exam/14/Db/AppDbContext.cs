using Microsoft.EntityFrameworkCore;
using app.Models;

namespace app.Db
{
	public class AppDbContext : DbContext
	{
		public DbSet<Group> Group { get; set; }
		public DbSet<Item> Item { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=./sqlite.db");
		}

		// protected override void OnModelCreating(ModelBuilder modelBuilder)
		// {
		// 	modelBuilder.Entity<Group>()
		// 			.Navigation(g => g.Items)
		// 			.AutoInclude();
		// }

		// public AppDbContext()
		// {
		// 	ChangeTracker.LazyLoadingEnabled = true;
		// }
	}
}
