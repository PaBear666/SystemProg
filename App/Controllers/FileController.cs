using App.Controllers.Abstractions;
using DAL.Entities;
using System.Collections.Generic;
using System;
using DAL.Providers.Abstractions;
using System.Linq;
using App.infrastructure;
using System.Linq;
using App.Infrastructure.Exceptions;

namespace App.Controllers
{
    internal class FileController : IFileController
    {
        private readonly IList<Resource> _resources;
        private readonly ILogger _logger;
        private IFileProvider _fileProvider;

        public event EventHandler<IList<Resource>> UpdateResourceHandler;

        public FileController(ILogger logger)
        {
            _logger = logger;
            _resources = new List<Resource>();
        }

        public void AddRecord(Resource resource)
        {
            resource.Id = _resources.Count > 0
                ? _resources.Last().Id + 1
                : 1;
            _resources.Add(resource);
            UpdateResourceHandler?.Invoke(this, _resources);
        }

        public void LoadFromFile(string path)
        {
            try
            {
                var resources = _fileProvider.LoadFromFile(path);

                if (resources.Select(r => r.Id).Distinct().Count() != resources.Count())
                {
                    throw new NotUniqFieldException("Найдено не уникальное значение ресурса");
                }

                _resources.Clear();
                foreach (var resource in resources)
                {
                    _resources.Add(resource);
                }
                UpdateResourceHandler?.Invoke(this, _resources);
            }
            catch(FormatException e)
            {
                _logger.LogError(e, "Неверный формат данных в файле");
            }
            catch(Exception e)
            {
                _logger.LogError(e);
            }
        }

        public void RemoveRecord(int id)
        {
            var resource = _resources.FirstOrDefault(r => r.Id == id);
            if(resource != null)
            {
                _resources.Remove(resource);
                UpdateResourceHandler?.Invoke(this, _resources);
                return;
            }
            _logger.LogError(new NotFoundException($"Не было найдено записи с id = {id}"));
            
        }

        public void UnloadToFile(string path)
        {
            _fileProvider.UnLoadToFile(path, _resources.ToArray());
        }

        public string SetFileProvider(IFileProvider fileProvider)
        {
            _fileProvider = fileProvider;
            return _fileProvider.PathExtension;
        }

        public Resource GetById(int id)
        {
            return _resources.FirstOrDefault(r => r.Id == id);
        }

        public void UpdateRecord(int id, Resource newResource)
        {
            var resource = GetById(id);
            resource.Address = newResource.Address;
            resource.AccessDate = newResource.AccessDate;
            resource.IsOpen = newResource.IsOpen;
            UpdateResourceHandler?.Invoke(this, _resources);
        }
    }
}
