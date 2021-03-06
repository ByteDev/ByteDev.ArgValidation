﻿using System.Globalization;

namespace ByteDev.ArgValidation
{
    public static partial class ArgMustBe
    {
        /// <summary>
        /// Ensures a param is greater than or equal to <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than or equal to <paramref name="value" />.</exception>
        public static void GreaterThanOrEqual(sbyte param, sbyte value, string paramName = null)
        {
            if (param < value)
                ExceptionThrower.ThrowGreaterThanOrEqualException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is greater than or equal to <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than or equal to <paramref name="value" />.</exception>
        public static void GreaterThanOrEqual(byte param, byte value, string paramName = null)
        {
            if (param < value)
                ExceptionThrower.ThrowGreaterThanOrEqualException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is greater than or equal to <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than or equal to <paramref name="value" />.</exception>
        public static void GreaterThanOrEqual(short param, short value, string paramName = null)
        {
            if (param < value)
                ExceptionThrower.ThrowGreaterThanOrEqualException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is greater than or equal to <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than or equal to <paramref name="value" />.</exception>
        public static void GreaterThanOrEqual(ushort param, ushort value, string paramName = null)
        {
            if (param < value)
                ExceptionThrower.ThrowGreaterThanOrEqualException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is greater than or equal to <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than or equal to <paramref name="value" />.</exception>
        public static void GreaterThanOrEqual(int param, int value, string paramName = null)
        {
            if (param < value)
                ExceptionThrower.ThrowGreaterThanOrEqualException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is greater than or equal to <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than or equal to <paramref name="value" />.</exception>
        public static void GreaterThanOrEqual(uint param, uint value, string paramName = null)
        {
            if (param < value)
                ExceptionThrower.ThrowGreaterThanOrEqualException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is greater than or equal to <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than or equal to <paramref name="value" />.</exception>
        public static void GreaterThanOrEqual(long param, long value, string paramName = null)
        {
            if (param < value)
                ExceptionThrower.ThrowGreaterThanOrEqualException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is greater than or equal to <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than or equal to <paramref name="value" />.</exception>
        public static void GreaterThanOrEqual(ulong param, ulong value, string paramName = null)
        {
            if (param < value)
                ExceptionThrower.ThrowGreaterThanOrEqualException(value.ToString(), paramName);
        }

        /// <summary>
        /// Ensures a param is greater than or equal to <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than or equal to <paramref name="value" />.</exception>
        public static void GreaterThanOrEqual(float param, float value, string paramName = null)
        {
            if (param < value)
                ExceptionThrower.ThrowGreaterThanOrEqualException(value.ToString(CultureInfo.InvariantCulture), paramName);
        }

        /// <summary>
        /// Ensures a param is greater than or equal to <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than or equal to <paramref name="value" />.</exception>
        public static void GreaterThanOrEqual(double param, double value, string paramName = null)
        {
            if (param < value)
                ExceptionThrower.ThrowGreaterThanOrEqualException(value.ToString(CultureInfo.InvariantCulture), paramName);
        }

        /// <summary>
        /// Ensures a param is greater than or equal to <paramref name="value" />.
        /// </summary>
        /// <param name="param">Parameter to check.</param>
        /// <param name="value">Value that the parameter must be greater than or equal to.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="param" /> must be greater than or equal to <paramref name="value" />.</exception>
        public static void GreaterThanOrEqual(decimal param, decimal value, string paramName = null)
        {
            if (param < value)
                ExceptionThrower.ThrowGreaterThanOrEqualException(value.ToString(CultureInfo.InvariantCulture), paramName);
        }

    }
}