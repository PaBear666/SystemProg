using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Presenters
{
    public class Resource
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

        #endregion
    }
}
