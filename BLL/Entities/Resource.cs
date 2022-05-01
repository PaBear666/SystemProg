using DAL.Entities;
using DAL.Providers.Abstractions;
using System;

namespace BLL.Entities
{
    public class Resource : IEntity<Resource>
    {

        /// <summary>
        /// Идентификатор ресурса
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Адрес ресурса
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Открытй ли ресурс
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// Дата доступа к ресурсу
        /// </summary>
        public DateTime AccessDate { get; set; }

        // Нужен для EF
        public Resource()
        {

        }

        public Resource(string address, bool isOpen, DateTime accessDate)
        {
            Address = address;
            IsOpen = isOpen;
            AccessDate = accessDate;
        }

        public Resource(int id, string address, bool isOpen, DateTime accessDate)
        {
            Id = id;
            Address = address;
            IsOpen = isOpen;
            AccessDate = accessDate;
        }

        public void Update(Resource newEntity)
        {
            Address = newEntity.Address;
            IsOpen = newEntity.IsOpen;
            AccessDate = newEntity.AccessDate;
        }
    }
}
