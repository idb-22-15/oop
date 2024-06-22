namespace app.Models
{
	public class Group
	{
		public int Id { get; set; }
		public required string Title { get; set; }
		public ICollection<Item> Items { get; set; } = [];

	}
}