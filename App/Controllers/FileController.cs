using App.Controllers.Abstractions;
using DAL.Entities;
using System.Collections;
using System.Collections.Generic;
using System;

namespace App.Controllers
{
    internal class FileController : IFileController
    {
        private readonly IList<Resource> _resources;
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
            throw new System.NotImplementedException();
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
    }
}
