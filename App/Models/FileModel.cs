using App.Controllers.Abstractions;
using DAL.Entities;
using System.Collections.Generic;
using System;
using DAL.Providers.Abstractions;
using System.Linq;
using App.Infrastructure;
using DAL.Repositories;
using DAL.Exceptions;
using App.Entities;

namespace App.Controllers
{
    internal class FileModel<T> : IFileModel<T>
        where T : class, IEntity
    {
        private readonly ILogger _logger;
        private IRepository<T> _repository; 
        private IFileProvider<T> _fileProvider;

        public event EventHandler<IList<T>> UpdateResourceHandler;

        public FileModel(ILogger logger)
        {
            _logger = logger;
        }

        public void AddRecord(T resource)
        {
            _repository.AddRecord(resource);
            UpdateResourceHandler(_repository,_repository.GetAll());
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
                _repository.AddNewRecords(resources.ToList());
                UpdateResourceHandler?.Invoke(_repository, _repository.GetAll());

            }
            catch(FormatException e)
            {
                _logger.LogError(e, "Неверный формат");
            }
            catch(Exception e)
            {
                _logger.LogError(e);
            }        
        }

        public void UnloadToFile(string path)
        {
            _fileProvider.UnLoadToFile(path, _repository.GetAll().ToArray());
        }

        public void RemoveRecord(int id)
        {
            try
            {
                _repository.RemoveRecord(id);
                UpdateResourceHandler(_repository, _repository.GetAll());
            }
            catch(Exception e)
            {
                _logger.LogError(new NotFoundException($"Не было найдено записи с id = {id}"));
            }
            
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void UpdateRecord(int id, T newResource)
        {
            _repository.UpdateRecord(id, newResource);
            UpdateResourceHandler(_repository, _repository.GetAll());
        }

        public string SetFileProvider(IFileProvider<T> fileProvider)
        {
            _fileProvider = fileProvider;
            return _fileProvider.PathExtension;
        }

        public void SetRepository(IRepository<T> repository)
        {
            _repository = repository;
            UpdateResourceHandler(_repository, _repository.GetAll());
        }
    }
}
