using App.Entities;
using System;


namespace App.Presenters
{
    class ActionModalPresenterFile : IActionModalPresenter<File>
    {
        public ActionModalPresenterFile(ModalAction action, File record)
        {
            
        }
        public void ShowDialog(Action<File> ok, Action cancel = null)
        {
            throw new NotImplementedException();
        }
    }
}
