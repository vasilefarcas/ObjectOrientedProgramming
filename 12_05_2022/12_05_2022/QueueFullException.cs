using System;
using System.Runtime.Serialization;

namespace _12_05_2022
{
    [Serializable]
    internal class QueueFullException : Exception
    {
        public QueueFullException()
        {
        }

        public QueueFullException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

        public QueueFullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected QueueFullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}