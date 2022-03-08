using DAL.Entities.Abstractions;
using System.Collections.Generic;
using System.IO;

namespace DAL.Entities
{
    public class PlainTextProvider : IFileProvider
    {
        public string PathExtension => "txt";

        public ICollection<Resource> LoadFromFile(string file)
        {
            List<Resource> resources = new List<Resource>();
            foreach (string line in File.ReadAllLines(file))
            {
                var parameters = line.Split(new[] { ',' });
                var resource = new Resource(
                    int.Parse(parameters[0]),
                    parameters[1],
                    bool.Parse(parameters[2]),
                    System.DateTime.Parse(parameters[3]));
                resources.Add(resource);
            }
            return resources;
        }

        public void UnLoadToFile(string file, Resource[] resources)
        {
            throw new System.NotImplementedException();
        }
    }
}
