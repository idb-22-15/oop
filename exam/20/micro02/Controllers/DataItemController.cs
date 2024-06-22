using Microsoft.AspNetCore.Mvc;
using micro02.Models;
using System.Text.Json;

namespace micro02.Controllers
{
    [ApiController]
    [Route("micro02/api/items")]
    public class DataItemController : ControllerBase
    {
        private readonly HttpClient client = new();

        [HttpGet()]
        async public Task<IActionResult> GetAll()
        {
            var response = await client.GetAsync("http://localhost:3000/micro01/api/items");


            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
                var items = JsonSerializer.Deserialize<List<DataItem>>(content);
                return Ok(items);
            }
            return BadRequest();
        }
    }
}