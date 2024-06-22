
using app.Db;
using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Repositories
{
    public class ItemRepository(AppDbContext db) : IItemRepository
    {

        public async Task<List<Item>> GetAllAsync()
        {
            return await db.Item.ToListAsync();
        }
        public async Task<Item> CreateAsync(string text)
        {
            Item item = new() { Text = text };
            db.Item.Add(item);
            await db.SaveChangesAsync();
            return item;
        }


    }
}