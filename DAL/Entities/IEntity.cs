using DAL.Providers.Abstractions;

namespace DAL.Entities
{
    public interface IEntity
    {
        int Id { get; set; }
        void Update(IEntity newEntity);
    }
}
