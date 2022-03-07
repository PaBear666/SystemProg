using DAL.Entities.Abstractions;
using System.Collections.Generic;
using System.IO;

namespace DAL.Entities
{
    class CSVProvider : IFileProvider
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
