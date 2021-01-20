using System;
using NUnit.Framework;

namespace ByteDev.ArgValidation.NetCore.PackageTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void WhenArgNotGreaterThanTwo_ThrowException()
        {
            const int myArg = 1;

            Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan(myArg, 2, nameof(myArg)));
        }

        [Test]
        public void WhenArgGreaterThenTwo_ThenDoNotThrowException()
        {
            const int myArg = 3;

            Assert.DoesNotThrow(() => ArgValidator.GreaterThan(myArg, 2, nameof(myArg)));
        }
    }
}