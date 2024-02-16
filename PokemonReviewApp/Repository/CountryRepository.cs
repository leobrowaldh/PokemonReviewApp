using AutoMapper;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;

namespace PokemonReviewApp.Repository;

public class CountryRepository : ICountryRepository
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public CountryRepository(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public bool CountryExists(int id) => _context.Countries.Any(c => c.Id == id);

    public ICollection<Country> GetCountries() => _context.Countries.ToList();

    public Country? GetCountry(int id) => _context.Countries.Find(id);

    public Country GetCountryByOwner(int ownerId) => 
        _context.Owners.Where(o => o.Id == ownerId).Select(c => c.Country).FirstOrDefault();

    public ICollection<Owner> GetOwnersFromCountry(int countryId) =>
        _context.Owners.Where(o => o.Country.Id == countryId).ToList();
}
