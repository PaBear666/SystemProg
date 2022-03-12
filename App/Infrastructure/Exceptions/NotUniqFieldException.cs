using System;

namespace App.Infrastructure.Exceptions
{
    class NotUniqFieldException : Exception
    {
        public NotUniqFieldException(string message) : base(message)
        {
                
        }
    }
}
