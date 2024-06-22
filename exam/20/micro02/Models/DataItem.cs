using System.Text.Json.Serialization;

namespace micro02.Models
{
  public class DataItem
  {
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    [JsonPropertyName("description")]
    public required string Description { get; set; }
  }
}