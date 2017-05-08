using System;
using System.Runtime.Serialization;

namespace CampoMinato
{
    [Serializable]
    public class FileNotExistsException : Exception
    {
        public FileNotExistsException()
        {
        }

        public FileNotExistsException(string message) : base(message)
        {
        }

        public FileNotExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FileNotExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}