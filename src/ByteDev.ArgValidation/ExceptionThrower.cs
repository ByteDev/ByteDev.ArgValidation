using System;

namespace ByteDev.ArgValidation
{
    internal static class ExceptionThrower
    {
        public static void ThrowLessThanException(string paramName, string value)
        {
            if(paramName != null)
                throw new ArgumentOutOfRangeException($"Parameter {paramName} must be less than {value}.", paramName);
                
            throw new ArgumentOutOfRangeException($"Parameter must be less than {value}.");
        }

        public static void ThrowLessThanOrEqualException(string paramName, string value)
        {
            if(paramName != null)
                throw new ArgumentOutOfRangeException($"Parameter {paramName} must be less than or equal to {value}.", paramName);
                
            throw new ArgumentOutOfRangeException($"Parameter must be less than or equal to {value}.");
        }

        public static void ThrowGreaterThanException(string paramName, string value)
        {
            if(paramName != null)
                throw new ArgumentOutOfRangeException($"Parameter {paramName} must be greater than {value}.", paramName);

            throw new ArgumentOutOfRangeException($"Parameter must be greater than {value}.");
        }

        public static void ThrowGreaterThanOrEqualException(string paramName, string value)
        {
            if(paramName != null)
                throw new ArgumentOutOfRangeException($"Parameter {paramName} must be greater than or equal to {value}.", paramName);

            throw new ArgumentOutOfRangeException($"Parameter must be greater than or equal to {value}.");
        }

        public static void ThrowIsEmptyException(string paramName)
        {
            throw new ArgumentException("Parameter cannot be empty.", paramName);
        }
    }
}
