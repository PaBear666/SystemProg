using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DAL.Repositories
{
    public class DbRepository : IRepository
    {
        private readonly string _connectionString;

        public DbRepository(string connection)
        {
            _connectionString = connection;
        }

        public void AddRecord(ResourceEntity resource)
        {
            using (Context.Context context = new Context.Context(_connectionString))
            {
                context.Set<ResourceEntity>().Add(resource);
                context.SaveChanges();
            }
        }

        public ResourceEntity GetById(int id)
        {
            using (Context.Context context = new Context.Context(_connectionString))
            {
                return context.Resources.Where(r => r.Id == id).FirstOrDefault();
            }
        }

        private ResourceEntity GetById(int id, Context.Context context)
        {
            return context.Resources.Where(r => r.Id == id).FirstOrDefault();
        }

        public void RemoveRecord(int id)
        {
            using (Context.Context context = new Context.Context(_connectionString))
            {
                context.Resources.Remove(GetById(id,context));
                context.SaveChanges();
            }
        }

        public void UpdateRecord(int id, ResourceEntity newResource)
        {
            using (Context.Context context = new Context.Context(_connectionString))
            {
                var resource = GetById(id,context);
                resource.Address = newResource.Address;
                resource.AccessDate = newResource.AccessDate;
                resource.IsOpen = newResource.IsOpen;
                context.SaveChanges();
            }
        }

        public IList<ResourceEntity> GetAll()
        {
            using (Context.Context context = new Context.Context(_connectionString))
            {
                return context.Resources.ToList();
            }
        }

        private IList<ResourceEntity> GetAll(Context.Context context)
        {
            return context.Resources.ToList();
        }

        public void AddNewRecords(IList<ResourceEntity> resources)
        {
            using (Context.Context context = new Context.Context(_connectionString))
            {
                context.Resources.RemoveRange(GetAll(context));
                context.Resources.AddRange(resources);
                context.SaveChanges();
            }
        }
    }
}
