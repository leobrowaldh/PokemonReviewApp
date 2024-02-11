using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository;

public class PokemonRepository : Repository, IPokemonRepository
{
	public Pokemon? GetPokemon(int id) => _context.Pokemons.Find(id);

	public Pokemon? GetPokemon(string name) => _context.Pokemons.FirstOrDefault(p => p.Name == name);

	public decimal GetPokemonRating(int pokeId)
	{
		var review = _context.Reviews.Where(r => r.Pokemon.Id == pokeId);
		if(!review.Any()) { return 0; }
		return ((decimal)review.Sum(r => r.Rating)/review.Count());
	}

	public ICollection<Pokemon> GetPokemons()
    {
        return _context.Pokemons.OrderBy(p => p.Id).ToList();
    }

	public bool PokemonExists(int pokeId) => _context.Pokemons.Any(p => p.Id == pokeId);
}
