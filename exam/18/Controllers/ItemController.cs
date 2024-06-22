using app.Db;
using app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace app.Controllers
{
    [ApiController]
    [Route("/api/items")]
    public class RoomController(AppDbContext db) : ControllerBase
    {
        [HttpGet()]
        public async Task<IActionResult> GetByTextStart([FromQuery] string? textStart)
        {
            var models = await db.Item.Where((i) => i.Text.StartsWith(textStart ?? "")).ToListAsync();
            return Ok(models);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] string text)
        {
            if (string.IsNullOrEmpty(text)) return BadRequest("Текст не может быть пустым");
            Item model = new() { Text = text };
            db.Item.Add(model);
            await db.SaveChangesAsync();
            return Ok(model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] string text)
        {
            var model = await db.Item.FindAsync(id);
            if (model == null) return NotFound();
            model.Text = text;
            await db.SaveChangesAsync();
            return Ok(model);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var model = await db.Item.FindAsync(id);
            if (model == null) return NotFound();
            db.Remove(model);
            await db.SaveChangesAsync();
            return NoContent();
        }
    }
}
