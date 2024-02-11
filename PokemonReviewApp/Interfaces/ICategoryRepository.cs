using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces;

public interface ICategoryRepository : IRepository
{
	ICollection<Pokemon> GetPokemonByCategory(int categoryId);
}
