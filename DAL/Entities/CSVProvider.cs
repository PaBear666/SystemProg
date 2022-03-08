using DAL.Entities.Abstractions;
using System.Collections.Generic;
using System.IO;

namespace DAL.Entities
{
    public class CSVProvider : IFileProvider
    {
        public string PathExtension => throw new System.NotImplementedException();

        public ICollection<Resource> LoadFromFile(string path)
        {
            throw new System.NotImplementedException();
        }

        public void UnLoadToFile(string path, Resource[] resources)
        {
            throw new System.NotImplementedException();
        }
    }
}
