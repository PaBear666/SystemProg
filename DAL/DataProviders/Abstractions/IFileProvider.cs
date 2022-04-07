using System.Collections.Generic;
using DAL.Entities;

namespace DAL.Providers.Abstractions
{
    public interface IFileProvider
    {
        /// <summary>
        /// Расширение файла
        /// </summary>
        string PathExtension { get; }
        /// <summary>
        /// Загрузить записи из файла
        /// </summary>
        /// <param name="file">Путь до файла</param>
        /// <returns>Коллекция ресурсов</returns>
        ICollection<ResourceEntity> LoadFromFile(string path);

        /// <summary>
        /// Загрузить записи в файл
        /// </summary>
        /// <param name="path">Путь до файла</param>
        /// <param name="resources">Ресурсы</param>
        void UnLoadToFile(string path, ResourceEntity[] resources); 
    }
}
