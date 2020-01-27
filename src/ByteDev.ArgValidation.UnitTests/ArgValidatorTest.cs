using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ByteDev.ArgValidation.UnitTests
{
    [TestFixture]
    public class ArgValidatorTest
    {
        [TestFixture]
        public class NotNull
        {
            [Test]
            public void WhenIsNull_ThenThrowException()
            {
                Assert.Throws<ArgumentNullException>(() => ArgValidator.NotNull(null as string));
            }
        }

        [TestFixture]
        public class NotDefault
        {
            [Test]
            public void WhenIsDefault_ThenThrowException()
            {
                const int number = default(int);
                Assert.Throws<ArgumentException>(() => ArgValidator.NotDefault(number, "number"));
            }
        }

        [TestFixture]
        public class NotNullOrEmpty
        {
            [Test]
            public void WhenNotNull_AndNotEmptyString_ThenNotThrowException()
            {
                const string param = "Test";

                ArgValidator.NotNullOrEmpty(param, "param");
            }

            [Test]
            public void WhenNullString_ThenThrowException()
            {
                string param = null;
                Assert.Throws<ArgumentNullException>(() => ArgValidator.NotNullOrEmpty(param, "param"));
            }

            [Test]
            public void WhenEmptyString_ThenThrowException()
            {
                var param = string.Empty;
                Assert.Throws<ArgumentException>(() => ArgValidator.NotNullOrEmpty(param, "param"));
            }

            [Test]
            public void WhenNotNull_AndNotEmptyEnumerable_ThenNotThrowException()
            {
                IEnumerable<int> param = new int[1];

                ArgValidator.NotNullOrEmpty(param, "param");
            }

            [Test]
            public void WhenNullEnumerable_ThenThrowException()
            {
                IEnumerable<int> param = null;
                Assert.Throws<ArgumentNullException>(() => ArgValidator.NotNullOrEmpty(param, "param"));
            }

            [Test]
            public void WhenEmptyEnumerable_ThenThrowException()
            {
                IEnumerable<int> param = new int[0];
                Assert.Throws<ArgumentException>(() => ArgValidator.NotNullOrEmpty(param, "param"));
            }
        }

        [TestFixture]
        public class GreaterThan
        {
            [Test]
            public void WhenIntParamGreaterThanValue_ThenNotThrowException()
            {
                const int param = int.MaxValue;                

                ArgValidator.GreaterThan(param, param - 1, "param");        
            }

            [Test]
            public void WhenIntParamLessThanValue_ThenThrowException()
            {
                const int param = int.MaxValue - 1;
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan(param, int.MaxValue, "param"));
            }

            [Test]
            public void WhenIntParamEqValue_ThenThrowException()
            {
                const int param = int.MaxValue;
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan(param, param, "param"));
            }

            [Test]
            public void WhenLongParamGreaterThanValue_ThenNotThrowException()
            {
                const long param = long.MaxValue;

                ArgValidator.GreaterThan(param, param - 1, "param");
            }

            [Test]
            public void WhenLongParamLessThanValue_ThenThrowException()
            {
                const long param = long.MaxValue - 1;
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan(param, long.MaxValue, "param"));
            }

            [Test]
            public void WhenLongParamEqValue_ThenThrowException()
            {
                const long param = long.MaxValue;
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan(param, param, "param"));
            }

            [Test]
            public void WhenDecimalParamGreaterThanValue_ThenNotThrowException()
            {
                const decimal param = decimal.MaxValue;

                ArgValidator.GreaterThan(param, param - 1, "param");
            }

            [Test]
            public void WhenDecimalParamLessThanValue_ThenThrowException()
            {
                const decimal param = decimal.MaxValue - 1;
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan(param, decimal.MaxValue, "param"));
            }

            [Test]
            public void WhenDecimalParamEqValue_ThenThrowException()
            {
                const decimal param = decimal.MaxValue;
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.GreaterThan(param, param, "param"));
            }
        }

        [TestFixture]
        public class LessThan
        {
            [Test]
            public void WhenIntParamLessThanValue_ThenNotThrowException()
            {
                const int param = int.MaxValue - 1;

                ArgValidator.LessThan(param, param + 1, "param");
            }

            [Test]
            public void WhenIntParamGreaterThanValue_ThenThrowException()
            {
                const int param = int.MaxValue;
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan(param, int.MaxValue - 1, "param"));
            }

            [Test]
            public void WhenIntParamEqValue_ThenThrowException()
            {
                const int param = int.MaxValue;
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan(param, param, "param"));                
            }

            [Test]
            public void WhenLongParamLessThanValue_ThenNotThrowException()
            {
                const long param = long.MaxValue - 1;

                ArgValidator.LessThan(param, param + 1, "param");
            }

            [Test]
            public void WhenLongParamGreaterThanValue_ThenThrowException()
            {
                const long param = long.MaxValue;
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan(param, long.MaxValue - 1, "param"));
            }

            [Test]
            public void WhenLongParamEqValue_ThenThrowException()
            {
                const long param = long.MaxValue;
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan(param, param, "param"));
            }

            [Test]
            public void WhenDecimalParamLessThanValue_ThenNotThrowException()
            {
                const decimal param = decimal.MaxValue - 1;

                ArgValidator.LessThan(param, param + 1, "param");
            }

            [Test]
            public void WhenDecimalParamGreaterThanValue_ThenThrowException()
            {
                const decimal param = decimal.MaxValue;
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan(param, decimal.MaxValue - 1, "param"));
            }

            [Test]
            public void WhenDecimalParamEqValue_ThenThrowException()
            {
                const decimal param = decimal.MaxValue;
                Assert.Throws<ArgumentOutOfRangeException>(() => ArgValidator.LessThan(param, param, "param"));
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
        public class NotEquals : ArgValidatorTest
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
        public class In : ArgValidatorTest
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
        public class NotIn : ArgValidatorTest
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
