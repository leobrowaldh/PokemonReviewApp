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
    public bool CategoryExists(int id)
	{
		throw new NotImplementedException();
	}

	public ICollection<Category> GetCategories()
	{
		throw new NotImplementedException();
	}

	public Category GetCategory(int id)
	{
		throw new NotImplementedException();
	}

	public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
	{
		throw new NotImplementedException();
	}
}
