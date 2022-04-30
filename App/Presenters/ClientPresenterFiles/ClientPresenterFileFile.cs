using App.Controllers;
using App.Controllers.Abstractions;
using App.Entities;
using App.Infrastructure;
using App.Providers;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Presenters
{
    class ClientPresenterFileFile : ClientPresenterFile<File>
    {

        public ClientPresenterFileFile(Client client, FileModel<File> fileModel, IRepository<File> repository) :
            base(client,
                fileModel,
                (m, r) => new ActionModalPresenterFile(m, r),
                client.dataGrid3,
                repository)
        {

        }

        public override void SetFileProvider()
        {
           // _fileExtension = _fileModel.SetFileProvider(new XMLProvider());
            _client.fileTypeCB.SelectedIndex = 2;
        }

        public override void UpdateTable(object sender, IList<File> resources)
        {
            throw new NotImplementedException();
        }
    }
}
