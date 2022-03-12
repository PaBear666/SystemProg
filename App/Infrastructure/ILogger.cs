using System;

namespace App.Infrastructure
{
    public interface ILogger
    {
        void LogError(Exception e, string message = null);
    }

}
