using System;
using System.Runtime.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperMarketAPI
{
    [Serializable]
    internal class SupermarketException : Exception
    {
        public SupermarketException()
        {
        }

        public SupermarketException(string? message) : base(message)
        {
        }

        public SupermarketException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SupermarketException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
