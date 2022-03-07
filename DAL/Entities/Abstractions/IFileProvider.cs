using DAL.Entities;
using System.IO;

namespace DAL.Entities.Abstractions
{
    public interface IFileProvider
    {
        /// <summary>
        /// Загрузить записи из файла
        /// </summary>
        /// <param name="file">Путь до файла</param>
        void LoadFromFile(string file);

        /// <summary>
        /// Загрузить записи в файл
        /// </summary>
        /// <param name="file">Путь до файла</param>
        /// <param name="resources">Ресурсы</param>
        void UnLoadToFile(string file, Resource[] resources); 
    }
}
