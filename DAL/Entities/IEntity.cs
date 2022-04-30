using DAL.Providers.Abstractions;

namespace DAL.Entities
{
    public interface IEntity
    {
        int Id { get; set; }
    }

    public interface IEntity<T> : IEntity
        where T : class
    {
        void Update(T newEntity);
    }
}
