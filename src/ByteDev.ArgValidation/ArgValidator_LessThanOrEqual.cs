using System.Globalization;

namespace ByteDev.ArgValidation
{
    public static partial class ArgValidator
    {
        /// <summary>
        /// Ensures a param is less than or equal to the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than or equal to <paramref name="value" />.</exception>
        public static void LessThanOrEqual(sbyte param, sbyte value, string paramName = null)
        {
            if (param > value)
                ExceptionThrower.ThrowLessThanOrEqualException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is less than or equal to the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than or equal to <paramref name="value" />.</exception>
        public static void LessThanOrEqual(byte param, byte value, string paramName = null)
        {
            if (param > value)
                ExceptionThrower.ThrowLessThanOrEqualException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is less than or equal to the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than or equal to <paramref name="value" />.</exception>
        public static void LessThanOrEqual(short param, short value, string paramName = null)
        {
            if (param > value)
                ExceptionThrower.ThrowLessThanOrEqualException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is less than or equal to the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than or equal to <paramref name="value" />.</exception>
        public static void LessThanOrEqual(ushort param, ushort value, string paramName = null)
        {
            if (param > value)
                ExceptionThrower.ThrowLessThanOrEqualException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is less than or equal to the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than or equal to <paramref name="value" />.</exception>
        public static void LessThanOrEqual(int param, int value, string paramName = null)
        {
            if (param > value)
                ExceptionThrower.ThrowLessThanOrEqualException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is less than or equal to the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than or equal to <paramref name="value" />.</exception>
        public static void LessThanOrEqual(uint param, uint value, string paramName = null)
        {
            if (param > value)
                ExceptionThrower.ThrowLessThanOrEqualException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is less than or equal to the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than or equal to <paramref name="value" />.</exception>
        public static void LessThanOrEqual(long param, long value, string paramName = null)
        {
            if (param > value)
                ExceptionThrower.ThrowLessThanOrEqualException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is less than or equal to the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than or equal to <paramref name="value" />.</exception>
        public static void LessThanOrEqual(ulong param, ulong value, string paramName = null)
        {
            if (param > value)
                ExceptionThrower.ThrowLessThanOrEqualException(paramName, value.ToString());
        }

        /// <summary>
        /// Ensures a param is less than or equal to the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than or equal to <paramref name="value" />.</exception>
        public static void LessThanOrEqual(float param, float value, string paramName = null)
        {
            if (param > value)
                ExceptionThrower.ThrowLessThanOrEqualException(paramName, value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Ensures a param is less than or equal to the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than or equal to <paramref name="value" />.</exception>
        public static void LessThanOrEqual(double param, double value, string paramName = null)
        {
            if (param > value)
                ExceptionThrower.ThrowLessThanOrEqualException(paramName, value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Ensures a param is less than or equal to the <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be less than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be less than or equal to <paramref name="value" />.</exception>
        public static void LessThanOrEqual(decimal param, decimal value, string paramName = null)
        {
            if (param > value)
                ExceptionThrower.ThrowLessThanException(paramName, value.ToString(CultureInfo.InvariantCulture));
        }
    }
}