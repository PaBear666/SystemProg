using System;

namespace App.infrastructure
{
    interface ILogger
    {
        void LogError(Exception e, string message = null);
    }

}
