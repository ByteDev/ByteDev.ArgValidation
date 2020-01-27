using System;

namespace ByteDev.ArgValidation
{
    internal static class ExceptionThrower
    {
        public static void DependentNotNullException<TDependent>(string dependentName)
        {
            if (dependentName == null)
                throw new DependentNullException($"Dependent type '{typeof(TDependent).FullName}' cannot be null.");

            throw new DependentNullException($"Dependent '{dependentName}' of type '{typeof(TDependent).FullName}' cannot be null.");
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
                throw new ArgumentException($"Parameter '{paramName}' cannot be empty.", paramName);
                
            throw new ArgumentException("Parameter cannot be empty.");
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
    }
}
