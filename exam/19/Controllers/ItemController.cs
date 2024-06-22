using app.Models;
using app.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    [ApiController]
    [Route("/api/items")]
    public class RoomController(IItemRepository itemRepository) : ControllerBase
    {
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await itemRepository.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] string text)
        {
            if (string.IsNullOrEmpty(text)) return BadRequest("Текст не может быть пустым");
            Item model = await itemRepository.CreateAsync(text);
            return Ok(model);
        }
    }
}
