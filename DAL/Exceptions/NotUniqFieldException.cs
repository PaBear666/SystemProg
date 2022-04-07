using System;

namespace DAL.Exceptions
{
    public class NotUniqFieldException : Exception
    {
        public NotUniqFieldException(string message) : base(message)
        {
                
        }
    }
}
