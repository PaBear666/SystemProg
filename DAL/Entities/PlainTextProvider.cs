using DAL.Entities.Abstractions;
using System.Collections.Generic;

namespace DAL.Entities
{
    class PlainTextProvider : IFileProvider
    {
        public ICollection<Resource> LoadFromFile(string file)
        {
            throw new System.NotImplementedException();
        }

        public void UnLoadToFile(string file, Resource[] resources)
        {
            throw new System.NotImplementedException();
        }
    }
}
