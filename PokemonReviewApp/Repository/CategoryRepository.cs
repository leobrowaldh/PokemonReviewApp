using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly DataContext _context;

    public CategoryRepository(DataContext context)
    {
        _context = context;
    }
    public bool CategoryExists(int categoryId) => _context.Categories.Any(c => c.Id == categoryId);

    public ICollection<Category> GetCategories() => _context.Categories.ToList();

    public Category? GetCategory(int id) => _context.Categories.Find(id);

    public ICollection<Pokemon> GetPokemonByCategory(int categoryId) => 
        _context.PokemonCategories.Where(c => c.CategoryId == categoryId).Select(p => p.Pokemon).ToList();
}
