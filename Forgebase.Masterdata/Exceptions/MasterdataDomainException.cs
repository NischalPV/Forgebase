using System;
namespace Forgebase.Masterdata.Exceptions
{
    public class MasterdataDomainException : Exception
    {
        public MasterdataDomainException() { }
        public MasterdataDomainException(string message) : base(message) { }
        public MasterdataDomainException(string message, Exception innerException) : base(message, innerException) { }
    }
}
