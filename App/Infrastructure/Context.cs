using App.Entities;
using DAL.Entities;
using System.Data.Entity;

namespace App.Infrastructure
{
    public class Context : DbContext
    {
        public DbSet<Resource> Resources { get; set; }
        public DbSet<FileRecord> FileRecords { get; set; }
        public DbSet<DllRecord> DllRecords { get; set; }

        public Context(string connectionString) : base(connectionString)
        {

        }
    }
}
