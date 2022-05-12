using System;

namespace BLL.Logger
{
    public interface ILogger
    {
        
        void LogError(Exception e, string message = null);
    }

}
