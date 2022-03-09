using DAL.Entities.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DAL.Entities
{
    public class CSVProvider : IFileProvider
    {
        public string PathExtension => "csv";

        public ICollection<Resource> LoadFromFile(string path)
        {
            List<Resource> resources = new List<Resource>();
            foreach (string line in File.ReadAllLines(path))
            {
                var parameters = line.Split(new[] { ';' });
                var resource = new Resource(
                    int.Parse(parameters[0]),
                    parameters[1],
                    bool.Parse(parameters[2]),
                    System.DateTime.Parse(parameters[3]));
                resources.Add(resource);
            }
            return resources;
        }

        public void UnLoadToFile(string path, Resource[] resources)
        {
            using (StreamWriter stream = new StreamWriter(path, false))
            {
                foreach (var resource in resources)
                {
                    var line = string.Format("{0};{1};{2};{3}", resource.Id, resource.Address, resource.IsOpen, resource.AccessDate);
                    stream.WriteLine(line);
                }
            }
        }
    }
}
