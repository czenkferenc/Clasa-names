using System;
using System.Runtime.Serialization;

namespace Clasa_names
{
    [Serializable]
    internal class NoNameFoundExcepion : Exception
    {
        public NoNameFoundExcepion()
        {
        }

        public NoNameFoundExcepion(string message) : base(message)
        {
        }

        public NoNameFoundExcepion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoNameFoundExcepion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}