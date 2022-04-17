using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Presenters
{
    class ActionModalPresenterAccess : IActionModalPresenter<Access>
    {
        public ActionModalPresenterAccess(ModalAction action, Access record)
        {

        }

        public void ShowDialog(Action<Access> ok, Action cancel = null)
        {
            throw new NotImplementedException();
        }
    }
}
