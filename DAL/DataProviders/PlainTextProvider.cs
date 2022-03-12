using DAL.Providers.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DAL.Entities;

namespace DAL.Providers
{
    public class PlainTextProvider : IFileProvider
    {
        public string PathExtension => "txt";

        public ICollection<Resource> LoadFromFile(string path)
        {
            List<Resource> resources = new List<Resource>();
            foreach (string line in File.ReadAllLines(path))
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

        public void UnLoadToFile(string path, Resource[] resources)
        {
            StringBuilder builder = new StringBuilder();
            using (StreamWriter stream = new StreamWriter(path, false))
            {
                foreach (var resource in resources)
                {
                    builder.Append($"{resource.Id},");
                    builder.Append($"{resource.Address},");
                    builder.Append($"{resource.IsOpen},");
                    builder.Append($"{resource.AccessDate}");
                    stream.WriteLine(builder);
                    builder.Clear();
                }
            }
        }
    }
}
