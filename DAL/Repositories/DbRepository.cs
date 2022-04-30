using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace DAL.Repositories
{
    public class DbRepository<T> : IRepository<T>
        where T: class,IEntity
    {
        private Func<DbContext> _getContext;

        public DbRepository(Func<DbContext> getContext)
        {
            _getContext = getContext;
        }

        public void AddRecord(T resource)
        {
            using (var context = _getContext())
            {
                context.Set<T>().Add(resource);
                context.SaveChanges();
            }
        }

        public T GetById(int id)
        {
            using (var context = _getContext())
            {
                return context.Set<T>().Where(r => r.Id == id).FirstOrDefault();
            }
        }

        private T GetById(int id, DbContext context)
        {
            return context.Set<T>().Where(r => r.Id == id).FirstOrDefault();
        }

        public void RemoveRecord(int id)
        {
            using (var context = _getContext())
            {
                context.Set<T>().Remove(GetById(id,context));
                context.SaveChanges();
            }
        }

        public void UpdateRecord(int id, T newResource)
        {
            using (var context = _getContext())
            {
                var resource = GetById(id,context);
                resource.Update(newResource);
                context.SaveChanges();
            }
        }

        public IList<T> GetAll()
        {
            using (var context = _getContext())
            {
                return context.Set<T>().ToList();
            }
        }

        private IList<T> GetAll(DbContext context)
        {
            return context.Set<T>().ToList();
        }

        public void AddNewRecords(IList<T> resources)
        {
            using (var context = _getContext())
            {
                context.Set<T>().RemoveRange(GetAll(context));
                context.Set<T>().AddRange(resources);
                context.SaveChanges();
            }
        }
    }
}
