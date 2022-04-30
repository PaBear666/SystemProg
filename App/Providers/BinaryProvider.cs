using App.Entities;
using DAL.Providers.Abstractions;
using System.Collections.Generic;

namespace App.Providers
{
    class BinaryProvider : IFileProvider<Access>
    {
        public string PathExtension => throw new System.NotImplementedException();

        public ICollection<Access> LoadFromFile(string path)
        {
            throw new System.NotImplementedException();
        }

        public void UnLoadToFile(string path, Access[] resources)
        {
            throw new System.NotImplementedException();
        }
    }
}
