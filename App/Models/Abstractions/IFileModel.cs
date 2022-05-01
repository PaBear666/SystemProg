using DAL.Entities;
using DAL.Providers.Abstractions;
using DAL.Repositories;
using System;
using System.Collections.Generic;

namespace App.Models.Abstractions
{
    public interface IFileModel<T> 
        where T : class,IEntity
    {
        /// <summary>
        /// Обработчик изменения списка
        /// </summary>
        event EventHandler<IList<T>> UpdateResourceHandler;

        /// <summary>
        /// Установить провайдер для работы с файлом
        /// </summary>
        /// <param name="fileProvider">Провайдер</param>
        /// <param name="repository">Репозиторий</param>
        /// <returns>Тип расширения</returns>
        string SetFileProvider(IFileProvider<T> fileProvider);

        /// <summary>
        /// Установить репозиторий
        /// </summary>
        /// <param name="repository">Репозиторий</param>
        void SetRepository(IRepository<T> repository);

        /// <summary>
        /// Добавить запись
        /// </summary>
        void AddRecord(T resource);

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
        void UpdateRecord(int id, T newResource);

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

        /// <summary>
        /// Получить запись по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор записи</param>
        /// <returns>Ресурс</returns>
        T GetById(int id);
    }
}