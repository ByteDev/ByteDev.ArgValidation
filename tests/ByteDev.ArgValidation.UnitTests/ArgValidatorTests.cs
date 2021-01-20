using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ByteDev.ArgValidation.UnitTests
{
    [TestFixture]
    public class ArgValidatorTests
    {
        [TestFixture]
        public class NotNull
        {
            [Test]
            public void WhenIsNull_ThenThrowException()
            {
                TestCustomer param = null;

                Assert.Throws<ArgumentNullException>(() => ArgValidator.NotNull(param));
            }

            [Test]
            public void WhenIsNotNull_ThenDoesNotThrowException()
            {
                var param = new TestCustomer();

                Assert.DoesNotThrow(() => ArgValidator.NotNull(param));
            }
        }

        [TestFixture]
        public class NotDefault
        {
            [Test]
            public void WhenIsDefault_ThenThrowException()
            {
                const int param = default;

                Assert.Throws<ArgumentException>(() => ArgValidator.NotDefault(param));
            }

            [Test]
            public void WhenIsNotDefault_ThenDoesNotThrowException()
            {
                const int param = 1;

                Assert.DoesNotThrow(() => ArgValidator.NotDefault(param));
            }
        }

        [TestFixture]
        public class NotNullOrEmpty
        {
            [Test]
            public void WhenNotNull_AndNotEmptyString_ThenNotThrowException()
            {
                const string param = "Test";

                Assert.DoesNotThrow(() => ArgValidator.NotNullOrEmpty(param));
            }

            [Test]
            public void WhenNullString_ThenThrowException()
            {
                string param = null;

                Assert.Throws<ArgumentNullException>(() => ArgValidator.NotNullOrEmpty(param));
            }

            [Test]
            public void WhenEmptyString_ThenThrowException()
            {
                string param = string.Empty;

                Assert.Throws<ArgumentException>(() => ArgValidator.NotNullOrEmpty(param));
            }

            [Test]
            public void WhenNotNull_AndNotEmptyEnumerable_ThenNotThrowException()
            {
                IEnumerable<int> param = new int[1];

                ArgValidator.NotNullOrEmpty(param);
            }

            [Test]
            public void WhenNullEnumerable_ThenThrowException()
            {
                IEnumerable<int> param = null;

                Assert.Throws<ArgumentNullException>(() => ArgValidator.NotNullOrEmpty(param));
            }

            [Test]
            public void WhenEmptyEnumerable_ThenThrowException()
            {
                IEnumerable<int> param = Enumerable.Empty<int>();

                Assert.Throws<ArgumentException>(() => ArgValidator.NotNullOrEmpty(param));
            }
        }

        [TestFixture]
        public class GreaterThan
        {
            [Test]
            public void WhenParamIsGreaterThanValue_ThenDoNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgValidator.GreaterThan((sbyte)2, (sbyte)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThan((byte)2, (byte)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThan((short)2, (short)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThan((ushort)2, (ushort)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThan((int)2, (int)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThan((uint)2, (uint)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThan((long)2, (long)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThan((ulong)2, (ulong)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThan(2.0f, 1.0f));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThan(2.0d, 1.0d));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThan(2.0M, 1.0M));
            }

            [Test]
            public void WhenParamIsEqualToValue_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((sbyte)1, (sbyte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((byte)1, (byte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((short)1, (short)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((ushort)1, (ushort)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((int)1, (int)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((uint)1, (uint)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((long)1, (long)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((ulong)1, (ulong)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan(1.0f, 1.0f));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan(1.0d, 1.0d));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan(1.0M, 1.0M));
            }

            [Test]
            public void WhenParamIsLessThanValue_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((sbyte)1, (sbyte)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((byte)1, (byte)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((short)1, (short)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((ushort)1, (ushort)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((int)1, (int)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((uint)1, (uint)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((long)1, (long)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan((ulong)1, (ulong)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan(1.0f, 2.0f));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan(1.0d, 2.0d));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan(1.0M, 2.0M));
            }
        }

        [TestFixture]
        public class GreaterThanOrEqual
        {
            [Test]
            public void WhenParamIsGreaterThanValue_ThenDoNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((sbyte)2, (sbyte)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((byte)2, (byte)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((short)2, (short)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((ushort)2, (ushort)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((int)2, (int)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((uint)2, (uint)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((long)2, (long)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((ulong)2, (ulong)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual(2.0f, 1.0f));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual(2.0d, 1.0d));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual(2.0M, 1.0M));
            }

            [Test]
            public void WhenParamIsEqualToValue_ThenThrowException()
            {
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((sbyte)1, (sbyte)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((byte)1, (byte)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((short)1, (short)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((ushort)1, (ushort)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((int)1, (int)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((uint)1, (uint)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((long)1, (long)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual((ulong)1, (ulong)1));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual(1.0f, 1.0f));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual(1.0d, 1.0d));
                Assert.DoesNotThrow(() => ArgValidator.GreaterThanOrEqual(1.0M, 1.0M));
            }

            [Test]
            public void WhenParamIsLessThanValue_ThenDoNotThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThanOrEqual((sbyte)1, (sbyte)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThanOrEqual((byte)1, (byte)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThanOrEqual((short)1, (short)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThanOrEqual((ushort)1, (ushort)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThanOrEqual((int)1, (int)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThanOrEqual((uint)1, (uint)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThanOrEqual((long)1, (long)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThanOrEqual((ulong)1, (ulong)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThanOrEqual(1.0f, 2.0f));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThanOrEqual(1.0d, 2.0d));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThanOrEqual(1.0M, 2.0M));
            }
        }

        [TestFixture]
        public class LessThan
        {
            [Test]
            public void WhenParamIsLessThanValue_ThenDoNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgValidator.LessThan((sbyte)1, (sbyte)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThan((byte)1, (byte)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThan((short)1, (short)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThan((ushort)1, (ushort)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThan((int)1, (int)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThan((uint)1, (uint)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThan((long)1, (long)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThan((ulong)1, (ulong)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThan(1.0f, 2.0f));
                Assert.DoesNotThrow(() => ArgValidator.LessThan(1.0d, 2.0d));
                Assert.DoesNotThrow(() => ArgValidator.LessThan(1.0M, 2.0M));
            }

            [Test]
            public void WhenParamIsEqualToValue_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((sbyte)1, (sbyte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((byte)1, (byte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((short)1, (short)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((ushort)1, (ushort)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((int)1, (int)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((uint)1, (uint)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((long)1, (long)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((ulong)1, (ulong)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan(1.0f, 1.0f));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan(1.0d, 1.0d));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan(1.0M, 1.0M));
            }

            [Test]
            public void WhenParamIsGreaterThanValue_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((sbyte)2, (sbyte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((byte)2, (byte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((short)2, (short)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((ushort)2, (ushort)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((int)2, (int)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((uint)2, (uint)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((long)2, (long)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan((ulong)2, (ulong)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan(2.0f, 1.0f));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan(2.0d, 1.0d));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan(2.0M, 1.0M));
            }
        }

        [TestFixture]
        public class LessThanOrEqual
        {
            [Test]
            public void WhenParamIsLessThanValue_ThenDoNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((sbyte)1, (sbyte)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((byte)1, (byte)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((short)1, (short)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((ushort)1, (ushort)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((int)1, (int)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((uint)1, (uint)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((long)1, (long)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((ulong)1, (ulong)2));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual(1.0f, 2.0f));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual(1.0d, 2.0d));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual(1.0M, 2.0M));
            }

            [Test]
            public void WhenParamIsEqualToValue_ThenDoNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((sbyte)1, (sbyte)1));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((byte)1, (byte)1));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((short)1, (short)1));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((ushort)1, (ushort)1));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((int)1, (int)1));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((uint)1, (uint)1));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((long)1, (long)1));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual((ulong)1, (ulong)1));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual(1.0f, 1.0f));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual(1.0d, 1.0d));
                Assert.DoesNotThrow(() => ArgValidator.LessThanOrEqual(1.0M, 1.0M));
            }

            [Test]
            public void WhenParamIsGreaterThanValue_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThanOrEqual((sbyte)2, (sbyte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThanOrEqual((byte)2, (byte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThanOrEqual((short)2, (short)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThanOrEqual((ushort)2, (ushort)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThanOrEqual((int)2, (int)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThanOrEqual((uint)2, (uint)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThanOrEqual((long)2, (long)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThanOrEqual((ulong)2, (ulong)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThanOrEqual(2.0f, 1.0f));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThanOrEqual(2.0d, 1.0d));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThanOrEqual(2.0M, 1.0M));
            }
        }
        
        [TestFixture]
        public class DependentNotNull
        {
            [Test]
            public void WhenIsNull_ThenThrowException()
            {
                Assert.Throws<DependentNullException>(() => ArgValidator.DependentNotNull(null as TestCustomer));
            }

            [Test]
            public void WhenIsNotNull_ThenThrowException()
            {
                Assert.DoesNotThrow(() => ArgValidator.DependentNotNull(new TestCustomer()));
            }
        }

        [TestFixture]
        public class NotEquals : ArgValidatorTests
        {
            [Test]
            public void WhenEqualsValue_ThenThrowsException()
            {
                const int param = 1;

                Assert.Throws<ArgumentException>(() => ArgValidator.NotEquals(param, 1));
            }

            [Test]
            public void WhenDoesNotEqualValue_ThenDoNotThrowException()
            {
                const int param = 1;

                Assert.DoesNotThrow(() => ArgValidator.NotEquals(param, 2));
            }
        }

        [TestFixture]
        public class In : ArgValidatorTests
        {
            private const int Param = 1;

            [Test]
            public void WhenParamValueIsNotInValues_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.In(Param, new[] {2, 3}));
            }

            [Test]
            public void WhenParamValueIsInValues_ThenDoNotThrowException()
            {

                Assert.DoesNotThrow(() => ArgValidator.In(Param, new[] { 2, 1, 3 }));
            }

            [Test]
            public void WhenValuesIsNull_ThenDoesNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgValidator.In(Param, null));
            }

            [Test]
            public void WhenValuesIsEmpty_ThenDoesNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgValidator.In(Param, new int[0]));
            }
        }

        [TestFixture]
        public class NotIn : ArgValidatorTests
        {
            private const int Param = 1;

            [Test]
            public void WhenParamValueIsInValues_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.NotIn(Param, new[] { 2, 1, 3 }));
            }

            [Test]
            public void WhenParamValueIsNotInValues_ThenDoNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgValidator.NotIn(Param, new[] { 2, 3 }));
            }

            [Test]
            public void WhenValuesIsNull_ThenDoesNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgValidator.NotIn(Param, null));
            }

            [Test]
            public void WhenValuesIsEmpty_ThenDoesNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgValidator.NotIn(Param, new int[0]));
            }
        }
    }

    public class TestCustomer
    {
    }
}
