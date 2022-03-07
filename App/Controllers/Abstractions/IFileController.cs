using DAL.Entities;
using System;
using System.Collections.Generic;

namespace App.Controllers.Abstractions
{
    public interface IFileController
    {
        /// <summary>
        /// Обработчик изменения списка
        /// </summary>
        event EventHandler<IList<Resource>> UpdateResourceHandler;

        /// <summary>
        /// Добавить запись
        /// </summary>
        void AddRecord();

        /// <summary>
        /// Удалить запись
        /// </summary>
        /// <param name="id">Идентификатор записи</param>
        void RemoveRecord(int id);

        /// <summary>
        /// Удалить запись
        /// </summary>
        /// <param name="id">Идентификатор записи</param>
        void UpdateRecord(int id);

        /// <summary>
        /// Получить все записи
        /// </summary>
        /// <returns>Перечисление ресурсов</returns>
        IEnumerable<Resource> GetAllRecord();

        /// <summary>
        /// Загрузить записи из файла
        /// </summary>
        /// <param name="path">Ссылка на файл</param>
        void LoadFromFile(string path);

        /// <summary>
        /// Выгрузить записи в файл
        /// </summary>
        /// <param name="path">Ссылка на файл</param>
        void UnloadToFile(string path);
    }
}