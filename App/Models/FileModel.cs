using App.Controllers.Abstractions;
using DAL.Entities;
using System.Collections.Generic;
using System;
using DAL.Providers.Abstractions;
using System.Linq;
using App.Infrastructure;
using DAL.Repositories;
using DAL.Exceptions;
using App.Presenters;

namespace App.Controllers
{
    internal class FileModel : IFileModel
    {
        private readonly ILogger _logger;
        private IRepository _repository; 
        private IFileProvider _fileProvider;

        public event EventHandler<IList<Resource>> UpdateResourceHandler;

        public FileModel(ILogger logger)
        {
            _logger = logger;
        }

        public void AddRecord(ResourceEntity resource)
        {
            _repository.AddRecord(resource);
            UpdateResourceHandler(_repository,_repository.GetAll().ToResource().ToList());
        }

        public void LoadFromFile(string path)
        {
            var resources = _fileProvider.LoadFromFile(path);
            try
            {
                if (resources.Select(r => r.Id).Distinct().Count() != resources.Count())
                {
                    throw new NotUniqFieldException("Найдено не уникальное значение ресурса");
                    _repository.AddNewRecords(resources.ToList());
                    UpdateResourceHandler?.Invoke(_repository, _repository.GetAll().ToResource().ToList());
                }

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
                UpdateResourceHandler(_repository, _repository.GetAll().ToResource().ToList());
            }
            catch(Exception e)
            {
                _logger.LogError(new NotFoundException($"Не было найдено записи с id = {id}"));
            }
            
        }

        public ResourceEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void UpdateRecord(int id, ResourceEntity newResource)
        {
            _repository.UpdateRecord(id, newResource);
            UpdateResourceHandler(_repository, _repository.GetAll().ToResource().ToList());
        }

        public string SetFileProvider(IFileProvider fileProvider)
        {
            _fileProvider = fileProvider;
            return _fileProvider.PathExtension;
        }

        public void SetRepository(IRepository repository)
        {
            _repository = repository;
            UpdateResourceHandler(_repository, _repository.GetAll().ToResource().ToList());
        }
    }
}
