using System;
using ByteDev.Exceptions;

namespace ByteDev.ArgValidation
{
    internal static class ExceptionThrower
    {
        public static void ThrowDependencyNullException<TDependent>(string dependentName)
        {
            if (dependentName == null)
                throw new DependencyNullException(typeof(TDependent));

            throw new DependencyNullException(typeof(TDependent), dependentName);
        }

        public static void ThrowArgumentDefaultException(string paramName)
        {
            if (paramName == null)
                throw new ArgumentDefaultException();

            throw new ArgumentDefaultException(paramName);
        }

        public static void ThrowLessThanException(string paramName, string value)
        {
            if(paramName != null)
                throw new ArgumentOutOfRangeException(paramName, $"Parameter '{paramName}' must be less than '{value}'.");
                
            throw new ArgumentOutOfRangeException($"Parameter must be less than '{value}'.");
        }

        public static void ThrowLessThanOrEqualException(string paramName, string value)
        {
            if(paramName != null)
                throw new ArgumentOutOfRangeException(paramName, $"Parameter '{paramName}' must be less than or equal to '{value}'.");
                
            throw new ArgumentOutOfRangeException($"Parameter must be less than or equal to '{value}'.");
        }

        public static void ThrowGreaterThanException(string paramName, string value)
        {
            if(paramName != null)
                throw new ArgumentOutOfRangeException(paramName, $"Parameter '{paramName}' must be greater than '{value}'.");

            throw new ArgumentOutOfRangeException($"Parameter must be greater than '{value}'.");
        }

        public static void ThrowGreaterThanOrEqualException(string paramName, string value)
        {
            if(paramName != null)
                throw new ArgumentOutOfRangeException(paramName, $"Parameter '{paramName}' must be greater than or equal to '{value}'.");

            throw new ArgumentOutOfRangeException($"Parameter must be greater than or equal to '{value}'.");
        }

        public static void ThrowIsEmptyException(string paramName)
        {
            if(paramName != null)
                throw new ArgumentEmptyException(paramName);
                
            throw new ArgumentEmptyException();
        }

        public static void ThrowInException<TParam>(TParam param, string paramName)
        {
            if (paramName == null)
                throw new ArgumentOutOfRangeException($"Parameter value: '{param}' was not in the provided sequence of values.");

            throw new ArgumentOutOfRangeException(paramName, $"Parameter '{paramName}' value: '{param}' was not in the provided sequence of values.");
        }

        public static void ThrowNotInException<TParam>(TParam param, string paramName)
        {
            if (paramName == null)
                throw new ArgumentOutOfRangeException($"Parameter value: '{param}' was in the provided sequence of values.");

            throw new ArgumentOutOfRangeException(paramName, $"Parameter '{paramName}' value: '{param}' was in the provided sequence of values.");
        }

        public static void ThrowIsNullOrEmptyException(string paramName)
        {
            if (paramName == null)
                throw new ArgumentNullOrEmptyException();

            throw new ArgumentNullOrEmptyException(paramName);
        }
    }
}
