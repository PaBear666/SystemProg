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
    public class FileRepository : IRepository
    {
        private readonly IList<ResourceEntity> _resources;

        public FileRepository()
        {
            _resources = new List<ResourceEntity>();
        }

        public void AddRecord(ResourceEntity resource)
        {
            resource.Id = _resources.Count > 0
                ? _resources.Last().Id + 1
                : 1;

            _resources.Add(resource);
        }

        public ResourceEntity GetById(int id)
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

        public void UpdateRecord(int id, ResourceEntity newResource)
        {
            var resource = GetById(id);
            resource.Address = newResource.Address;
            resource.AccessDate = newResource.AccessDate;
            resource.IsOpen = newResource.IsOpen;
        }

        public IList<ResourceEntity> GetAll()
        {
            return _resources;
        }

        public void AddNewRecords(IList<ResourceEntity> resources)
        {
            _resources.Clear();
            foreach (var resource in resources)
            {
                _resources.Add(resource);
            }
        }
    }
}
