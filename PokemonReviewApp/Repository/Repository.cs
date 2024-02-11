using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;

namespace PokemonReviewApp.Repository;

public class Repository : IRepository
{
	protected readonly DataContext _context;

	public Repository(DataContext context)
    {
		_context = context;
	}
	public bool EntityExists<TEntity>(int id) where TEntity : class, IEntity
		=> _context.Set<TEntity>().Any<TEntity>(e => e.Id == id);

	public TEntity? GetEntity<TEntity>(int id) where TEntity : class, IEntity
		=> _context.Set<TEntity>().Find(id);

	public ICollection<TEntity> GetEntityCollection<TEntity>() where TEntity : class, IEntity
		=> _context.Set<TEntity>().OrderBy(e => e.Id).ToList();
}
