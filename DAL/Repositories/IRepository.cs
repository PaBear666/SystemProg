using DAL.Entities;
using System.Collections.Generic;


namespace DAL.Repositories
{
    public interface IRepository
    {
        /// <summary>
        /// Добавить запись
        /// </summary>
        void AddRecord(Resource resource);

        /// <summary>
        /// Загрузить новые значения
        /// </summary>
        /// <param name="resources">Новые значения</param>
        void AddNewRecords(IList<Resource> resources);

        /// <summary>
        /// Удалить запись
        /// </summary>
        /// <param name="id">Идентификатор записи</param>
        void RemoveRecord(int id);

        /// <summary>
        /// Обновить запись
        /// </summary>
        /// <param name="id">Идентификатор записи</param>
        /// <param name="newResource">Измененый ресурс</param>
        void UpdateRecord(int id, Resource newResource);

        /// <summary>
        /// Получить запись по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор записи</param>
        /// <returns>Ресурс</returns>
        Resource GetById(int id);

        /// <summary>
        /// Получить все элементы
        /// </summary>
        /// <returns>Список ресурсов</returns>
        IList<Resource> GetAll();
    }
}
