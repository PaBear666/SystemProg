using App.Controllers.Abstractions;
using DAL.Entities;
using System.Collections.Generic;
using System;
using DAL.Providers.Abstractions;
using System.Linq;
using App.Infrastructure;
using DAL.Repositories;
using DAL.Exceptions;

namespace App.Controllers
{
    internal class FileController : IFileController
    {
        private readonly ILogger _logger;
        private IRepository _repository; 
        private IFileProvider _fileProvider;

        public event EventHandler<IList<Resource>> UpdateResourceHandler;

        public FileController(ILogger logger)
        {
            _logger = logger;
        }

        public void AddRecord(Resource resource)
        {
            _repository.AddRecord(resource);
            UpdateResourceHandler(_repository,_repository.GetAll());
        }

        public void LoadFromFile(string path)
        {
            var resources = _fileProvider.LoadFromFile(path);

            if (resources.Select(r => r.Id).Distinct().Count() != resources.Count())
            {
                throw new NotUniqFieldException("Найдено не уникальное значение ресурса");
            }

            _repository.AddNewRecords(resources.ToList());
            UpdateResourceHandler?.Invoke(_repository, _repository.GetAll());
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

        public Resource GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void UpdateRecord(int id, Resource newResource)
        {
            _repository.UpdateRecord(id, newResource);
            UpdateResourceHandler(_repository, _repository.GetAll());
        }

        public string SetFileProvider(IFileProvider fileProvider)
        {
            _fileProvider = fileProvider;
            return _fileProvider.PathExtension;
        }

        public void SetRepository(IRepository repository)
        {
            _repository = repository;
            UpdateResourceHandler(_repository, _repository.GetAll());
        }
    }
}
