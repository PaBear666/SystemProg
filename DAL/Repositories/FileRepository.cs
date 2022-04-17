using DAL.Entities;
using DAL.Exceptions;
using DAL.Providers.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class FileRepository <T> : IRepository<T> 
        where T : class, IEntity
    {
        private readonly IList<T> _resources;

        public FileRepository()
        {
            _resources = new List<T>();
        }

        public void AddRecord(T resource)
        {
            resource.Id = _resources.Count > 0
                ? _resources.Last().Id + 1
                : 1;

            _resources.Add(resource);
        }

        public T GetById(int id)
        {
            return _resources.FirstOrDefault(r => r.Id == id);
        }

        public void RemoveRecord(int id)
        {
            var resource = _resources.FirstOrDefault(r => r.Id == id);
            if (resource != null)
            {
                _resources.Remove(resource);
                return;
            }
        }

        public void UpdateRecord(int id, T newResource)
        {
            var resource = GetById(id);
            resource.Update(newResource);
        }

        public IList<T> GetAll()
        {
            return _resources;
        }

        public void AddNewRecords(IList<T> resources)
        {
            _resources.Clear();
            foreach (var resource in resources)
            {
                _resources.Add(resource);
            }
        }
    }
}
