using System;
using ByteDev.Exceptions;

namespace ByteDev.ArgValidation
{
    internal static class ExceptionThrower
    {
        public static void ThrowDependencyNullException<TDependent>(string paramName)
        {
            if (paramName == null)
                throw new DependencyNullException(typeof(TDependent));

            throw new DependencyNullException(typeof(TDependent), paramName);
        }

        public static void ThrowArgumentDefaultException(string paramName)
        {
            if (paramName == null)
                throw new ArgumentDefaultException();

            throw new ArgumentDefaultException(paramName);
        }

        public static void ThrowIsEmptyException(string paramName)
        {
            if (paramName == null) 
                throw new ArgumentEmptyException();

            throw new ArgumentEmptyException(paramName);
        }

        public static void ThrowIsNullOrEmptyException(string paramName)
        {
            if (paramName == null)
                throw new ArgumentNullOrEmptyException();
            
            throw new ArgumentNullOrEmptyException(paramName);
        }

        public static void ThrowIsNullOrWhiteSpace(string paramName)
        {
            if (paramName == null) 
                throw new ArgumentNullOrWhiteSpaceException();

            throw new ArgumentNullOrWhiteSpaceException(paramName);
        }

        public static void ThrowLessThanException(string paramValue, string paramName)
        {
            var message = $"Parameter must be less than '{paramValue}'.";

            if (paramName == null)
                throw new ArgumentOutOfRangeException(message);

            throw new ArgumentOutOfRangeException(paramName, message);
        }

        public static void ThrowLessThanOrEqualException(string paramValue, string paramName)
        {
            var message = $"Parameter must be less than or equal to '{paramValue}'.";

            if (paramName == null)
                throw new ArgumentOutOfRangeException(message);

            throw new ArgumentOutOfRangeException(paramName, message);
        }

        public static void ThrowGreaterThanException(string paramValue, string paramName)
        {
            var message = $"Parameter must be greater than '{paramValue}'.";

            if (paramName == null)
                throw new ArgumentOutOfRangeException(message, null as Exception);

            throw new ArgumentOutOfRangeException(paramName, message);
        }

        public static void ThrowGreaterThanOrEqualException(string paramValue, string paramName)
        {
            var message = $"Parameter must be greater than or equal to '{paramValue}'.";

            if (paramName == null)
                throw new ArgumentOutOfRangeException(message, null as Exception);

            throw new ArgumentOutOfRangeException(paramName, message);
        }

        public static void ThrowInException<TParam>(TParam paramValue, string paramName)
        {
            var message = $"Parameter value: '{paramValue}' was not in the allowed sequence of values.";

            if (paramName == null)
                throw new ArgumentOutOfRangeException(message, null as Exception);

            throw new ArgumentOutOfRangeException(paramName, message);
        }

        public static void ThrowNotInException<TParam>(TParam paramValue, string paramName)
        {
            var message = $"Parameter value: '{paramValue}' was in the not allowed sequence of values.";

            if (paramName == null)
                throw new ArgumentOutOfRangeException(message, null as Exception);

            throw new ArgumentOutOfRangeException(paramName, message);
        }

        public static void ThrowNotBetween<TParam>(TParam paramValue, TParam from, TParam to, string paramName)
        {
            var message = $"Parameter value: '{paramValue}' was not between '{from}' and '{to}'.";

            if (paramName == null)
                throw new ArgumentOutOfRangeException(message, null as Exception);

            throw new ArgumentOutOfRangeException(paramName, message);
        }
    }
}
