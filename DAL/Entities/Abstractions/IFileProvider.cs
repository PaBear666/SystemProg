using System.Collections.Generic;

namespace DAL.Entities.Abstractions
{
    public interface IFileProvider
    {
        /// <summary>
        /// Название расширения
        /// </summary>
        string PathExtension { get; }
        /// <summary>
        /// Загрузить записи из файла
        /// </summary>
        /// <param name="file">Путь до файла</param>
        /// <returns>Коллекция ресурсов</returns>
        ICollection<Resource> LoadFromFile(string file);

        /// <summary>
        /// Загрузить записи в файл
        /// </summary>
        /// <param name="file">Путь до файла</param>
        /// <param name="resources">Ресурсы</param>
        void UnLoadToFile(string file, Resource[] resources); 
    }
}
