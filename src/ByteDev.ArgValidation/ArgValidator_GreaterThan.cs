using System.Globalization;

namespace ByteDev.ArgValidation
{
    public static partial class ArgValidator
    {
        /// <summary>
        /// Ensures a param is greater than <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than <paramref name="value" />.</exception>
        public static void GreaterThan(sbyte param, sbyte value, string paramName = null)
        {
            if (param <= value)
                ExceptionThrower.ThrowGreaterThanException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is greater than <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than <paramref name="value" />.</exception>
        public static void GreaterThan(byte param, byte value, string paramName = null)
        {
            if (param <= value)
                ExceptionThrower.ThrowGreaterThanException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is greater than <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than <paramref name="value" />.</exception>
        public static void GreaterThan(short param, short value, string paramName = null)
        {
            if (param <= value)
                ExceptionThrower.ThrowGreaterThanException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is greater than <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than <paramref name="value" />.</exception>
        public static void GreaterThan(ushort param, ushort value, string paramName = null)
        {
            if (param <= value)
                ExceptionThrower.ThrowGreaterThanException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is greater than <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than <paramref name="value" />.</exception>
        public static void GreaterThan(int param, int value, string paramName = null)
        {
            if (param <= value)
                ExceptionThrower.ThrowGreaterThanException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is greater than <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than <paramref name="value" />.</exception>
        public static void GreaterThan(uint param, uint value, string paramName = null)
        {
            if (param <= value)
                ExceptionThrower.ThrowGreaterThanException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is greater than <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than <paramref name="value" />.</exception>
        public static void GreaterThan(long param, long value, string paramName = null)
        {
            if (param <= value)
                ExceptionThrower.ThrowGreaterThanException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is greater than <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than <paramref name="value" />.</exception>
        public static void GreaterThan(ulong param, ulong value, string paramName = null)
        {
            if (param <= value)
                ExceptionThrower.ThrowGreaterThanException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is greater than <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than <paramref name="value" />.</exception>
        public static void GreaterThan(float param, float value, string paramName = null)
        {
            if (param <= value)
                ExceptionThrower.ThrowGreaterThanException(paramName, value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Ensures a param is greater than <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than <paramref name="value" />.</exception>
        public static void GreaterThan(double param, double value, string paramName = null)
        {
            if (param <= value)
                ExceptionThrower.ThrowGreaterThanException(paramName, value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Ensures a param is greater than <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than <paramref name="value" />.</exception>
        public static void GreaterThan(decimal param, decimal value, string paramName = null)
        {
            if (param <= value)
                ExceptionThrower.ThrowGreaterThanException(paramName, value.ToString(CultureInfo.InvariantCulture));
        }

    }
}