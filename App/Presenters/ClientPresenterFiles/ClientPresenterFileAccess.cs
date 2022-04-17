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
    class ClientPresenterFileAccess : ClientPresenterFile<Access>
    {

        public ClientPresenterFileAccess(Client client, FileModel<Access> fileModel, IRepository<Access> repository)
            :base(client,
                fileModel,
                (m, r) => new ActionModalPresenterAccess(m, r),
                client.dataGrid2,
                repository)
        {

        }

        public override void SetFileProvider()
        {
            //_fileExtension = _fileModel.SetFileProvider(new BinaryProvider());
            _client.fileTypeCB.SelectedIndex = 1;
        }

        public override void UpdateTable(object sender, IList<Access> resources)
        {
            
        }
    }
}
