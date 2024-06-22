namespace app.Models
{
	public class Item
	{
		public int GroupId { get; set; }
		public Group? Group { get; set; }
		public int Id { get; set; }
		public bool IsOk { get; set; }
	}
}