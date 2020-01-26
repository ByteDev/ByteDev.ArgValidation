using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ByteDev.ArgValidation
{
    public static partial class ArgValidator
    {
        /// <summary>
        /// Ensures an injected dependent is not null.
        /// </summary>
        /// <typeparam name="TDependent">Type of dependent.</typeparam>
        /// <param name="dependent">Dependent to check.</param>
        /// <param name="dependentName">Name of the dependent parameter.</param>
        /// <exception cref="T:ByteDev.ArgValidation.DependentNullException"><paramref name="dependent" /> is null.</exception>
        public static void DependentNotNull<TDependent>(TDependent dependent, string dependentName = null) where TDependent : class
        {
            if (dependent == null)
            {
                if (dependentName == null)
                    throw new DependentNullException($"Dependent type '{typeof(TDependent).FullName}' cannot be null.");

                throw new DependentNullException($"Dependent '{dependentName}' of type '{typeof(TDependent).FullName}' cannot be null.");
            }
        }

        /// <summary>
        /// Ensures an object is not null.
        /// </summary>
        /// <typeparam name="TParam">Type of parameter being checked.</typeparam>
        /// <param name="param">Parameter to check.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="param" /> is null.</exception>
        public static void NotNull<TParam>(TParam param, string paramName = null) where TParam : class
        {
            if (param == null)
                throw new ArgumentNullException(paramName);
        }

        /// <summary>
        /// Ensures a value type is not its default value.
        /// </summary>
        /// <typeparam name="TParam">Type of parameter being checked.</typeparam>
        /// <param name="param">Parameter to check.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="param" /> is it's default value.</exception>
        public static void NotDefault<TParam>(TParam param, string paramName = null) where TParam : struct
        {
            if (param.Equals(default(TParam)))
                throw new ArgumentException("Parameter cannot be it's default value.", paramName);
        }

        /// <summary>
        /// Ensures a string is not empty.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="param" /> is empty.</exception>
        public static void NotEmpty(string param, string paramName = null)
        {
            if (param == string.Empty)
                ExceptionThrower.ThrowIsEmptyException(paramName);
        }

        /// <summary>
        /// Ensures a collection is not empty.
        /// </summary>
        /// <typeparam name="TItem">Type of items in the collection.</typeparam>
        /// <param name="param">Parameter to check.</param>
        /// <param name="paramName">Name of parameter.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="param" /> is empty.</exception>
        public static void NotEmpty<TItem>(IEnumerable<TItem> param, string paramName = null)
        {
            if (!param.Any())
                ExceptionThrower.ThrowIsEmptyException(paramName);
        }

        /// <summary>
        /// Ensures a string is not null or empty.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="param" /> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="param" /> is empty.</exception>
        public static void NotNullOrEmpty(string param, string paramName = null)
        {
            NotNull(param, paramName);
            NotEmpty(param, paramName);
        }

        /// <summary>
        /// Ensures a collection is not null or empty.
        /// </summary>
        /// <typeparam name="TItem">Type of items in the collection.</typeparam>
        /// <param name="param">Parameter to check.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="param" /> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="param" /> is empty.</exception>
        public static void NotNullOrEmpty<TItem>(IEnumerable<TItem> param, string paramName = null)
        {
            NotNull(param, paramName);
            NotEmpty(param, paramName);
        }

        /// <summary>
        /// Ensures a parameter does not equal <paramref name="value" />.
        /// </summary>
        /// <typeparam name="TParam">Type of parameter.</typeparam>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must not equal.</param>
        /// <param name="paramName">Name of the parameter.</param>
        public static void NotEquals<TParam>(TParam param, TParam value, string paramName = null)
        {
            if(param.Equals(value))
                throw new ArgumentException($"Parameter cannot be equal to {value}.", paramName);
        }
    }
}
