using Microsoft.AspNetCore.Mvc;
using micro01.Models;

namespace micro01.Controllers
{
    [ApiController]
    [Route("micro01/api/items")]
    public class ItemController : ControllerBase
    {
        private static readonly List<Item> _items =
        [
            new() { Id = 1, Name = "Item 1", Description = "Description 1" },
            new() { Id = 2, Name = "Item 2", Description = "Description 2" },
            new() { Id = 3, Name = "Item 3", Description = "Description 3" }
        ];

        [HttpGet()]
        public IActionResult GetAll()
        {
            return Ok(_items);
        }
    }
}