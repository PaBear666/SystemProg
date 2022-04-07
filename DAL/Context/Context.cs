using DAL.Entities;
using System.Data.Entity;

namespace DAL.Context
{
    public class Context : DbContext
    {
        public DbSet<ResourceEntity> Resources { get; set; }

        public Context(string connectionString) : base(connectionString)
        {

        }
    }
}
