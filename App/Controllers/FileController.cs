using App.Controllers.Abstractions;
using DAL.Entities;
using System.Collections.Generic;
using System;
using DAL.Entities.Abstractions;
using System.Linq;

namespace App.Controllers
{
    internal class FileController : IFileController
    {
        private readonly IList<Resource> _resources;

        private IFileProvider _fileProvider;

        public event EventHandler<IList<Resource>> UpdateResourceHandler;

        public FileController()
        {
            _resources = new List<Resource>();
        }

        public void AddRecord()
        {
            var modal = new ActionModal(FileAction.Add, null);
            modal.ShowDialog(r =>
            {
                r.Id = _resources.Count + 1;
                _resources.Add(r);
                UpdateResourceHandler?.Invoke(this, _resources);
            });
        }

        public IEnumerable<Resource> GetAllRecord()
        {
            throw new System.NotImplementedException();
        }

        public void LoadFromFile(string path)
        {
            var resources = _fileProvider.LoadFromFile(path);
            _resources.Clear();
            foreach (var resource in resources)
            {
                _resources.Add(resource);
            }
            UpdateResourceHandler?.Invoke(this, _resources);
        }

        public void RemoveRecord(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UnloadToFile(string path)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateRecord(int id)
        {
            throw new System.NotImplementedException();
        }

        public string SetFileProvider(IFileProvider fileProvider)
        {
            _fileProvider = fileProvider;
            return _fileProvider.PathExtension;
        }
    }
}
