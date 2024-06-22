using app.Models;
namespace app.Repositories
{
    public interface IItemRepository
    {
        public Task<List<Item>> GetAllAsync();
        public Task<Item> CreateAsync(string text);
    }
}