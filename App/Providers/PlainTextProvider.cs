using App.Entities;
using DAL.Providers.Abstractions;
using System.Collections.Generic;
using System.IO;

namespace App.Providers
{
    class PlainTextProvider: IFileProvider<DllRecord>, IFileProvider<Resource>
    {
        public string PathExtension => "txt";

        public ICollection<DllRecord> LoadFromFile(string path)
        {
            List<DllRecord> dllRecords = new List<DllRecord>();
            foreach (string line in File.ReadAllLines(path))
            {
                var parameters = line.Split(new[] { ';' });
                var record = new DllRecord(
                    int.Parse(parameters[0]),
                    parameters[1],
                    parameters[2],
                    System.DateTime.Parse(parameters[3]));
                dllRecords.Add(record);
            }
            return dllRecords;
        }

        ICollection<Resource> IFileProvider<Resource>.LoadFromFile(string path)
        {
            List<Resource> resources = new List<Resource>();
            foreach (string line in File.ReadAllLines(path))
            {
                var parameters = line.Split(new[] { ';' });
                var record = new Resource(
                    int.Parse(parameters[0]),
                    parameters[1],
                    bool.Parse(parameters[2]),
                    System.DateTime.Parse(parameters[3]));
                resources.Add(record);
            }
            return resources;
        }
        public void UnLoadToFile(string path, DllRecord[] resources)
        {
            using (StreamWriter stream = new StreamWriter(path, false))
            {
                foreach (var resource in resources)
                {
                    var line = string.Format("{0};{1};{2};{3}",
                        resource.Id,
                        resource.Name,
                        resource.Version,
                        resource.LastEditDate);

                    stream.WriteLine(line);
                }
            }
        }

        public void UnLoadToFile(string path, Resource[] resources)
        {
            using (StreamWriter stream = new StreamWriter(path, false))
            {
                foreach (var resource in resources)
                {
                    var line = string.Format("{0};{1};{2};{3}",
                        resource.Id,
                        resource.Address,
                        resource.IsOpen,
                        resource.AccessDate);

                    stream.WriteLine(line);
                }
            }
        }


    }
}
