using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class FileRecord : IEntity<FileRecord>
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ссыкла на файл
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Размер в МБ
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Дата последнего редактирования
        /// </summary>
        public DateTime LastEditDate { get; set; }

        // Нужен для EF
        public FileRecord()
        {

        }

        public FileRecord(string path, int size, DateTime lastEditDate)
        {
            Path = path;
            Size = size;
            LastEditDate = lastEditDate;
        }

        public FileRecord(int id, string path, int size, DateTime lastEditDate)
        {
            Id = id;
            Path = path;
            Size = size;
            LastEditDate = lastEditDate;
        }

        public void Update(FileRecord newEntity)
        {
            Path = newEntity.Path;
            Size = newEntity.Size;
            LastEditDate = newEntity.LastEditDate;
        }
    }
}
