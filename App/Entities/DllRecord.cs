using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class DllRecord : IEntity<DllRecord>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Версия
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// Дата последнего редактирования
        /// </summary>
        public DateTime LastEditDate { get; set; }

        // Нужен для EF
        public DllRecord()
        {

        }

        public DllRecord(string name, string version, DateTime lastEditDate)
        {
            Name = name;
            Version = version;
            LastEditDate = lastEditDate;
        }

        public DllRecord(int id, string name, string version, DateTime lastEditDate)
        {
            Id = id;
            Name = name;
            Version = version;
            LastEditDate = lastEditDate;
        }

        public void Update(DllRecord newEntity)
        {
            Name = newEntity.Name;
            Version = newEntity.Version;
            LastEditDate = newEntity.LastEditDate;
        }
    }
}
