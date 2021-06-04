using System.Globalization;

namespace ByteDev.ArgValidation
{
    public static partial class ArgMustBe
    {
        /// <summary>
        /// Ensures a param is less than the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than <paramref name="value" />.</exception>
        public static void LessThan(sbyte param, sbyte value, string paramName = null)
        {
            if (param >= value)
                ExceptionThrower.ThrowLessThanException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is less than the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than <paramref name="value" />.</exception>
        public static void LessThan(byte param, byte value, string paramName = null)
        {
            if (param >= value)
                ExceptionThrower.ThrowLessThanException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is less than the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than <paramref name="value" />.</exception>
        public static void LessThan(short param, short value, string paramName = null)
        {
            if (param >= value)
                ExceptionThrower.ThrowLessThanException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is less than the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than <paramref name="value" />.</exception>
        public static void LessThan(ushort param, ushort value, string paramName = null)
        {
            if (param >= value)
                ExceptionThrower.ThrowLessThanException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is less than the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than <paramref name="value" />.</exception>
        public static void LessThan(int param, int value, string paramName = null)
        {
            if (param >= value)
                ExceptionThrower.ThrowLessThanException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is less than the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than <paramref name="value" />.</exception>
        public static void LessThan(uint param, uint value, string paramName = null)
        {
            if (param >= value)
                ExceptionThrower.ThrowLessThanException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is less than the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than <paramref name="value" />.</exception>
        public static void LessThan(long param, long value, string paramName = null)
        {
            if (param >= value)
                ExceptionThrower.ThrowLessThanException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is less than the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than <paramref name="value" />.</exception>
        public static void LessThan(ulong param, ulong value, string paramName = null)
        {
            if (param >= value)
                ExceptionThrower.ThrowLessThanException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is less than the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than <paramref name="value" />.</exception>
        public static void LessThan(float param, float value, string paramName = null)
        {
            if (param >= value)
                ExceptionThrower.ThrowLessThanException(value.ToString(CultureInfo.InvariantCulture), paramName);
        }

        /// <summary>
        /// Ensures a param is less than the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than <paramref name="value" />.</exception>
        public static void LessThan(double param, double value, string paramName = null)
        {
            if (param >= value)
                ExceptionThrower.ThrowLessThanException(value.ToString(CultureInfo.InvariantCulture), paramName);
        }

        /// <summary>
        /// Ensures a param is less than the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than <paramref name="value" />.</exception>
        public static void LessThan(decimal param, decimal value, string paramName = null)
        {
            if (param >= value)
                ExceptionThrower.ThrowLessThanException(value.ToString(CultureInfo.InvariantCulture), paramName);
        }
    }
}