using System;

namespace OnkoSoft.Data.Exceptions
{
    [Serializable]
    public class DatabaseManagerException : Exception
    {
        public DatabaseManagerException()
        { }

        public DatabaseManagerException(string message)
            : base(message)
        { }

        public DatabaseManagerException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}