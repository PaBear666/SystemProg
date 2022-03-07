using DAL.Entities.Abstractions;
using System.IO;

namespace DAL.Entities
{
    class PlainTextProvider : IFileProvider
    {
        public void LoadFromFile(string file)
        {
            throw new System.NotImplementedException();
        }

        public void UnLoadToFile(string file, Resource[] resources)
        {
            throw new System.NotImplementedException();
        }
    }
}
