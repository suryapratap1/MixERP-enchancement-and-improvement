using System;
using System.ComponentModel;

namespace PetaPoco
{
    [Serializable]
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException() { }

        public UnauthorizedException([Localizable(true)]string message)
            : base(message)
        { }

        public UnauthorizedException([Localizable(true)]string message, Exception exception)
            : base(message, exception)
        { }

    }
}