using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Presenters
{
    public interface IActionModalPresenter<T> where T: class, IEntity
    {
        void ShowDialog(Action<T> ok, Action cancel = null); 
    }
}
