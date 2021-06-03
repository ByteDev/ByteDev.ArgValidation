using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteDev.ArgValidation
{
    /// <summary>
    /// Represents a set of helper methods for argument validation.
    /// </summary>
    public static partial class ArgMustBe
    {
        /// <summary>
        /// Ensures an injected dependency parameter is not null.
        /// </summary>
        /// <typeparam name="TDependency">Type of dependency.</typeparam>
        /// <param name="dependency">Dependency to check.</param>
        /// <param name="dependencyName">Name of the dependency parameter.</param>
        /// <exception cref="T:ByteDev.Exceptions.DependencyNullException"><paramref name="dependency" /> is null.</exception>
        public static void NotNullDependency<TDependency>(TDependency dependency, string dependencyName = null) where TDependency : class
        {
            if (dependency == null)
                ExceptionThrower.ThrowDependencyNullException<TDependency>(dependencyName);
        }

        /// <summary>
        /// Ensures a parameter is not null.
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
        /// Ensures a parameter is not its default value.
        /// </summary>
        /// <typeparam name="TParam">Type of parameter being checked.</typeparam>
        /// <param name="param">Parameter to check.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:ByteDev.Exceptions.ArgumentDefaultException"><paramref name="param" /> is it's default value.</exception>
        public static void NotDefault<TParam>(TParam param, string paramName = null) where TParam : struct
        {
            if (param.Equals(default(TParam)))
                ExceptionThrower.ThrowArgumentDefaultException(paramName);
        }
        
        /// <summary>
        /// Ensures a string is not empty.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:ByteDev.Exceptions.ArgumentEmptyException"><paramref name="param" /> is empty.</exception>
        public static void NotEmpty(string param, string paramName = null)
        {
            if (param == string.Empty)
                ExceptionThrower.ThrowIsEmptyException(paramName);
        }

        /// <summary>
        /// Ensures a sequence is not empty.
        /// </summary>
        /// <typeparam name="TItem">Type of items in the collection.</typeparam>
        /// <param name="param">Parameter to check.</param>
        /// <param name="paramName">Name of parameter.</param>
        /// <exception cref="T:ByteDev.Exceptions.ArgumentEmptyException"><paramref name="param" /> is empty.</exception>
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
        /// <exception cref="T:ByteDev.Exceptions.ArgumentNullOrEmptyException"><paramref name="param" /> is null or empty.</exception>
        public static void NotNullOrEmpty(string param, string paramName = null)
        {
            if (string.IsNullOrEmpty(param))
                ExceptionThrower.ThrowIsNullOrEmptyException(paramName);
        }

        /// <summary>
        /// Ensures a sequence is not null or empty.
        /// </summary>
        /// <typeparam name="TItem">Type of items in the collection.</typeparam>
        /// <param name="param">Parameter to check.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:ByteDev.Exceptions.ArgumentNullOrEmptyException"><paramref name="param" /> is null or empty.</exception>
        public static void NotNullOrEmpty<TItem>(IEnumerable<TItem> param, string paramName = null)
        {
            if (param == null || !param.Any())
                ExceptionThrower.ThrowIsNullOrEmptyException(paramName);
        }

        /// <summary>
        /// Ensures a parameter does not equal <paramref name="value" />.
        /// </summary>
        /// <typeparam name="TParam">Type of parameter.</typeparam>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must not equal.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="param" /> is equal to <paramref name="value" />.</exception>
        public static void NotEquals<TParam>(TParam param, TParam value, string paramName = null)
        {
            if (param == null)
            {
                if (value == null)
                {
                    throw new ArgumentException("Parameter cannot be equal to null.", paramName);
                }
            }
            else if (param.Equals(value))
            {
                throw new ArgumentException($"Parameter cannot be equal to '{value}'.", paramName);
            }
        }

        /// <summary>
        /// Ensures a parameter is contained in a sequence of values.
        /// </summary>
        /// <typeparam name="TParam">Type of parameter.</typeparam>
        /// <param name="param">Parameter to check.</param>
        /// <param name="values">Set of values to check against.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be in the sequence of provided values.</exception>
        public static void In<TParam>(TParam param, IEnumerable<TParam> values, string paramName = null)
        {
            if (values == null || !values.Any())
                return;

            if (values.Contains(param))
                return;

            ExceptionThrower.ThrowInException(param, paramName);
        }

        /// <summary>
        /// Ensures a parameter is not contained in a sequence of values.
        /// </summary>
        /// <typeparam name="TParam">Type of parameter.</typeparam>
        /// <param name="param">Parameter to check.</param>
        /// <param name="values">Set of values to check against.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must not be in the sequence of provided values.</exception>
        public static void NotIn<TParam>(TParam param, IEnumerable<TParam> values, string paramName = null)
        {
            if (values == null)
                return;

            if (values.Contains(param))
                ExceptionThrower.ThrowNotInException(param, paramName);
        }
    }
}

