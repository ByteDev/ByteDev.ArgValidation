using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ByteDev.ArgValidation.UnitTests
{
    internal static class AssetEx
    {
        /// <summary>
        /// Assert that <paramref name="action" /> does not cause an exception.
        /// </summary>
        /// <param name="action">Action to evaluate.</param>
        public static void DoesNotThrow(Action action)
        {
            try
            {
                action();
            }
            catch (Exception)
            {
                Assert.Fail("Expected no exception to be thrown.");
            }
        }

        /// <summary>
        /// Assert that <paramref name="action" /> does not cause an exception <typeparamref name="TException" />.
        /// </summary>
        /// <typeparam name="TException">Type of exception that should not be thrown.</typeparam>
        /// <param name="action">Action to evaluate.</param>
        public static void DoesNotThrow<TException>(Action action) where TException : Exception
        {
            try
            {
                action();
            }
            catch (TException)
            {
                Assert.Fail($"Expected no exception of type {typeof(TException).Name} to be thrown.");
            }
        }

        /// <summary>
        /// Assert that <paramref name="func" /> does not cause an exception <typeparamref name="TException" />.
        /// </summary>
        /// <typeparam name="TException">Type of exception that should not be thrown.</typeparam>
        /// <param name="func">Func to evaluate.</param>
        /// <returns>Task representing the asynchronous operation.</returns>
        public static async Task DoesNotThrowAsync<TException>(Func<Task> func) where TException : Exception
        {
            try
            {
                await func();
            }
            catch (TException)
            {
                Assert.Fail($"Expected no exception of type {typeof(TException).Name} to be thrown.");
            }
        }
    }
}