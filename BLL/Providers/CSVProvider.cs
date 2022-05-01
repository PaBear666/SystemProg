using BLL.Entities;
using DAL.Providers.Abstractions;
using System.Collections.Generic;
using System.IO;

namespace BLL.Providers
{
    public class CSVProvider : IFileProvider<FileRecord>
    {
        public string PathExtension => "csv";

        public void UnLoadToFile(string path, FileRecord[] resources)
        {
            using (StreamWriter stream = new StreamWriter(path, false))
            {
                foreach (var resource in resources)
                {
                    var line = string.Format("{0};{1};{2};{3}",
                        resource.Id,
                        resource.Path,
                        resource.Size,
                        resource.LastEditDate);

                    stream.WriteLine(line);
                }
            }
        }

        public ICollection<FileRecord> LoadFromFile(string path)
        {
            List<FileRecord> records = new List<FileRecord>();
            foreach (string line in File.ReadAllLines(path))
            {
                var parameters = line.Split(new[] { ';' });
                var record = new FileRecord(
                    int.Parse(parameters[0]),
                    parameters[1],
                    int.Parse(parameters[2]),
                    System.DateTime.Parse(parameters[3]));
                records.Add(record);
            }
            return records;
        }
    }
}
