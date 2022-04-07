using System;

namespace DAL.Entities
{
    public class ResourceEntity
    {

        #region Properties 

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

        #endregion

        #region Ctors

        public ResourceEntity()
        {
                
        }

        public ResourceEntity(string address, bool isOpen, DateTime accessDate)
        {
            Address = address;
            IsOpen = isOpen;
            AccessDate = accessDate;
        }

        public ResourceEntity(int id, string address, bool isOpen, DateTime accessDate)
        {
            Id = id;
            Address = address;
            IsOpen = isOpen;
            AccessDate = accessDate;
        }

        #endregion
    }
}
