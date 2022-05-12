﻿using System;
using System.Runtime.Serialization;

namespace _12_05_2022
{
    [Serializable]
    internal class QueueEmptyException : Exception
    {
        public QueueEmptyException()
        {
        }

        public QueueEmptyException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

        public QueueEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected QueueEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}