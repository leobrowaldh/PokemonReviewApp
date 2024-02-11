using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces;

public interface IPokemonRepository : IRepository
{
    Pokemon? GetPokemon(string name);
    decimal GetPokemonRating(int pokeId);
}
