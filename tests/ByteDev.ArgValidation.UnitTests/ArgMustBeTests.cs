using System;
using System.Collections.Generic;
using System.Linq;
using ByteDev.Exceptions;
using NUnit.Framework;

namespace ByteDev.ArgValidation.UnitTests
{
    [TestFixture]
    public class ArgMustBeTests
    {
        [TestFixture]
        public class NotNullDependency
        {
            [Test]
            public void WhenIsNull_ThenThrowException()
            {
                Assert.Throws<DependencyNullException>(() => ArgMustBe.NotNullDependency(null as object));
            }

            [Test]
            public void WhenIsNotNull_ThenThrowException()
            {
                Assert.DoesNotThrow(() => ArgMustBe.NotNullDependency(new object()));
            }
        }

        [TestFixture]
        public class NotNull
        {
            [Test]
            public void WhenIsNull_ThenThrowException()
            {
                object param = null;

                Assert.Throws<ArgumentNullException>(() => ArgMustBe.NotNull(param));
            }

            [Test]
            public void WhenIsNotNull_ThenDoesNotThrowException()
            {
                var param = new object();

                Assert.DoesNotThrow(() => ArgMustBe.NotNull(param));
            }
        }

        [TestFixture]
        public class NotDefault
        {
            [Test]
            public void WhenIsDefault_ThenThrowException()
            {
                const int param = default;

                Assert.Throws<ArgumentDefaultException>(() => ArgMustBe.NotDefault(param));
            }

            [Test]
            public void WhenIsNotDefault_ThenDoesNotThrowException()
            {
                const int param = 1;

                Assert.DoesNotThrow(() => ArgMustBe.NotDefault(param));
            }
        }

        [TestFixture]
        public class NotEmpty : ArgMustBeTests
        {
            [TestCase("A")]
            [TestCase(null)]
            public void WhenNotEmpty_ThenNotThrowException(string param)
            {
                Assert.DoesNotThrow(() => ArgMustBe.NotEmpty(param));
            }

            [Test]
            public void WhenStringIsEmpty_ThenThrowException()
            {
                Assert.Throws<ArgumentEmptyException>(() => ArgMustBe.NotEmpty(string.Empty));
            }

            [Test]
            public void WhenCollectionIsEmpty_ThenThrowException()
            {
                Assert.Throws<ArgumentEmptyException>(() => ArgMustBe.NotEmpty(Enumerable.Empty<string>()));
            }
        }

        [TestFixture]
        public class NotNullOrEmpty
        {
            [Test]
            public void WhenNotNull_AndNotEmptyString_ThenNotThrowException()
            {
                const string param = "Test";

                Assert.DoesNotThrow(() => ArgMustBe.NotNullOrEmpty(param));
            }

            [Test]
            public void WhenNullString_ThenThrowException()
            {
                string param = null;

                Assert.Throws<ArgumentNullOrEmptyException>(() => ArgMustBe.NotNullOrEmpty(param));
            }

            [Test]
            public void WhenEmptyString_ThenThrowException()
            {
                string param = string.Empty;

                Assert.Throws<ArgumentNullOrEmptyException>(() => ArgMustBe.NotNullOrEmpty(param));
            }

            [Test]
            public void WhenNotNull_AndNotEmptyEnumerable_ThenNotThrowException()
            {
                IEnumerable<int> param = new int[1];

                ArgMustBe.NotNullOrEmpty(param);
            }

            [Test]
            public void WhenNullEnumerable_ThenThrowException()
            {
                IEnumerable<int> param = null;

                Assert.Throws<ArgumentNullOrEmptyException>(() => ArgMustBe.NotNullOrEmpty(param));
            }

            [Test]
            public void WhenEmptyEnumerable_ThenThrowException()
            {
                IEnumerable<int> param = Enumerable.Empty<int>();

                Assert.Throws<ArgumentNullOrEmptyException>(() => ArgMustBe.NotNullOrEmpty(param));
            }
        }

        [TestFixture]
        public class NotEquals : ArgMustBeTests
        {
            [Test]
            public void WhenEqualsValue_ThenThrowException()
            {
                const int param = 1;

                Assert.Throws<ArgumentException>(() => ArgMustBe.NotEquals(param, 1));
            }

            [Test]
            public void WhenEqualsValue_AndNull_ThenThrowException()
            {
                Assert.Throws<ArgumentException>(() => ArgMustBe.NotEquals(null as object, null));
            }

            [Test]
            public void WhenDoesNotEqualValue_ThenDoNotThrowException()
            {
                const int param = 1;

                Assert.DoesNotThrow(() => ArgMustBe.NotEquals(param, 2));
            }

            [Test]
            public void WhenParamIsNull_AndValueIsNotNull_ThenDoNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgMustBe.NotEquals(null as object, 1));
            }
        }

        [TestFixture]
        public class In : ArgMustBeTests
        {
            private const int Param = 1;

            [Test]
            public void WhenParamValueIsNotInValues_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.In(Param, new[] {2, 3}));
            }

            [Test]
            public void WhenParamValueIsInValues_ThenDoNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgMustBe.In(Param, new[] { 2, 1, 3 }));
            }

            [Test]
            public void WhenValuesIsNull_ThenDoesNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgMustBe.In(Param, null));
            }

            [Test]
            public void WhenValuesIsEmpty_ThenDoesNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgMustBe.In(Param, Enumerable.Empty<int>()));
            }
        }

        [TestFixture]
        public class NotIn : ArgMustBeTests
        {
            private const int Param = 1;

            [Test]
            public void WhenParamValueIsInValues_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.NotIn(Param, new[] { 2, 1, 3 }));
            }

            [Test]
            public void WhenParamValueIsNotInValues_ThenDoNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgMustBe.NotIn(Param, new[] { 2, 3 }));
            }

            [Test]
            public void WhenValuesIsNull_ThenDoesNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgMustBe.NotIn(Param, null));
            }

            [Test]
            public void WhenValuesIsEmpty_ThenDoesNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgMustBe.NotIn(Param, new int[0]));
            }
        }

        [TestFixture]
        public class GreaterThan
        {
            [Test]
            public void WhenParamIsGreaterThanValue_ThenDoNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThan((sbyte)2, (sbyte)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThan((byte)2, (byte)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThan((short)2, (short)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThan((ushort)2, (ushort)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThan((int)2, (int)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThan((uint)2, (uint)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThan((long)2, (long)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThan((ulong)2, (ulong)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThan(2.0f, 1.0f));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThan(2.0d, 1.0d));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThan(2.0M, 1.0M));
            }

            [Test]
            public void WhenParamIsEqualToValue_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((sbyte)1, (sbyte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((byte)1, (byte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((short)1, (short)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((ushort)1, (ushort)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((int)1, (int)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((uint)1, (uint)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((long)1, (long)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((ulong)1, (ulong)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan(1.0f, 1.0f));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan(1.0d, 1.0d));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan(1.0M, 1.0M));
            }

            [Test]
            public void WhenParamIsLessThanValue_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((sbyte)1, (sbyte)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((byte)1, (byte)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((short)1, (short)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((ushort)1, (ushort)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((int)1, (int)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((uint)1, (uint)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((long)1, (long)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan((ulong)1, (ulong)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan(1.0f, 2.0f));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan(1.0d, 2.0d));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThan(1.0M, 2.0M));
            }
        }

        [TestFixture]
        public class GreaterThanOrEqual
        {
            [Test]
            public void WhenParamIsGreaterThanValue_ThenDoNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((sbyte)2, (sbyte)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((byte)2, (byte)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((short)2, (short)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((ushort)2, (ushort)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((int)2, (int)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((uint)2, (uint)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((long)2, (long)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((ulong)2, (ulong)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual(2.0f, 1.0f));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual(2.0d, 1.0d));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual(2.0M, 1.0M));
            }

            [Test]
            public void WhenParamIsEqualToValue_ThenThrowException()
            {
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((sbyte)1, (sbyte)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((byte)1, (byte)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((short)1, (short)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((ushort)1, (ushort)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((int)1, (int)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((uint)1, (uint)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((long)1, (long)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual((ulong)1, (ulong)1));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual(1.0f, 1.0f));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual(1.0d, 1.0d));
                Assert.DoesNotThrow(() => ArgMustBe.GreaterThanOrEqual(1.0M, 1.0M));
            }

            [Test]
            public void WhenParamIsLessThanValue_ThenDoNotThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThanOrEqual((sbyte)1, (sbyte)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThanOrEqual((byte)1, (byte)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThanOrEqual((short)1, (short)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThanOrEqual((ushort)1, (ushort)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThanOrEqual((int)1, (int)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThanOrEqual((uint)1, (uint)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThanOrEqual((long)1, (long)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThanOrEqual((ulong)1, (ulong)2));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThanOrEqual(1.0f, 2.0f));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThanOrEqual(1.0d, 2.0d));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.GreaterThanOrEqual(1.0M, 2.0M));
            }
        }

        [TestFixture]
        public class LessThan
        {
            [Test]
            public void WhenParamIsLessThanValue_ThenDoNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgMustBe.LessThan((sbyte)1, (sbyte)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThan((byte)1, (byte)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThan((short)1, (short)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThan((ushort)1, (ushort)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThan((int)1, (int)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThan((uint)1, (uint)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThan((long)1, (long)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThan((ulong)1, (ulong)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThan(1.0f, 2.0f));
                Assert.DoesNotThrow(() => ArgMustBe.LessThan(1.0d, 2.0d));
                Assert.DoesNotThrow(() => ArgMustBe.LessThan(1.0M, 2.0M));
            }

            [Test]
            public void WhenParamIsEqualToValue_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((sbyte)1, (sbyte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((byte)1, (byte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((short)1, (short)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((ushort)1, (ushort)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((int)1, (int)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((uint)1, (uint)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((long)1, (long)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((ulong)1, (ulong)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan(1.0f, 1.0f));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan(1.0d, 1.0d));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan(1.0M, 1.0M));
            }

            [Test]
            public void WhenParamIsGreaterThanValue_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((sbyte)2, (sbyte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((byte)2, (byte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((short)2, (short)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((ushort)2, (ushort)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((int)2, (int)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((uint)2, (uint)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((long)2, (long)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan((ulong)2, (ulong)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan(2.0f, 1.0f));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan(2.0d, 1.0d));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThan(2.0M, 1.0M));
            }
        }

        [TestFixture]
        public class LessThanOrEqual
        {
            [Test]
            public void WhenParamIsLessThanValue_ThenDoNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((sbyte)1, (sbyte)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((byte)1, (byte)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((short)1, (short)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((ushort)1, (ushort)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((int)1, (int)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((uint)1, (uint)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((long)1, (long)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((ulong)1, (ulong)2));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual(1.0f, 2.0f));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual(1.0d, 2.0d));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual(1.0M, 2.0M));
            }

            [Test]
            public void WhenParamIsEqualToValue_ThenDoNotThrowException()
            {
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((sbyte)1, (sbyte)1));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((byte)1, (byte)1));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((short)1, (short)1));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((ushort)1, (ushort)1));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((int)1, (int)1));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((uint)1, (uint)1));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((long)1, (long)1));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual((ulong)1, (ulong)1));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual(1.0f, 1.0f));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual(1.0d, 1.0d));
                Assert.DoesNotThrow(() => ArgMustBe.LessThanOrEqual(1.0M, 1.0M));
            }

            [Test]
            public void WhenParamIsGreaterThanValue_ThenThrowException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThanOrEqual((sbyte)2, (sbyte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThanOrEqual((byte)2, (byte)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThanOrEqual((short)2, (short)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThanOrEqual((ushort)2, (ushort)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThanOrEqual((int)2, (int)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThanOrEqual((uint)2, (uint)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThanOrEqual((long)2, (long)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThanOrEqual((ulong)2, (ulong)1));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThanOrEqual(2.0f, 1.0f));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThanOrEqual(2.0d, 1.0d));
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgMustBe.LessThanOrEqual(2.0M, 1.0M));
            }
        }
    }
}
