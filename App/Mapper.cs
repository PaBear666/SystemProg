using App.Presenters;
using DAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    static class Mapper
    {
        public static Resource ToResource(this ResourceEntity resourceEntity)
        {
            return new Resource(resourceEntity.Id, resourceEntity.Address, resourceEntity.IsOpen, resourceEntity.AccessDate);
        }

        public static ResourceEntity ToResourceEntity(this Resource resource)
        {
            return new ResourceEntity(resource.Id, resource.Address, resource.IsOpen, resource.AccessDate);
        }

        public static IEnumerable<Resource> ToResource(this IEnumerable<ResourceEntity> resourceEntities)
        {
            return resourceEntities.Select(x => x.ToResource());
        }

        public static IEnumerable<ResourceEntity>ToResourceEntity(this IEnumerable<Resource> resources)
        {
            return resources.Select(x => x.ToResourceEntity());
        }
    }
}
