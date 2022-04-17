using App.Entities;
using DAL.Providers.Abstractions;
using System.Collections.Generic;

namespace App.Providers
{
    class XMLProvider : IFileProvider<File>
    {
        public string PathExtension => throw new System.NotImplementedException();

        public ICollection<File> LoadFromFile(string path)
        {
            throw new System.NotImplementedException();
        }

        public void UnLoadToFile(string path, File[] resources)
        {
            throw new System.NotImplementedException();
        }
    }
}
