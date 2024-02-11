using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IRepository
    {
        ICollection<TEntity> GetEntityCollection<TEntity>() where TEntity : class, IEntity;
        TEntity? GetEntity<TEntity>(int id) where TEntity : class, IEntity;
        bool EntityExists<TEntity>(int id) where TEntity : class, IEntity;
    }
}
