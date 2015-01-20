using System;
using NUnit.Framework;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestFixture]
    public class when_calculate_is_called
    {
        [TestFixture]
        public class given_an_empty_string
        {
            [Test]
            public void it_should_return_zero()
            {
                int result = new Calculator().CalculateSum(String.Empty);
                Assert.That(result, Is.EqualTo(0));
            }
        }

        [TestFixture]
        public class given_a_null_string
        {
            [Test]
            public void it_should_throw_an_argument_null_exception()
            {
                var calculator = new Calculator();
                Assert.Throws<ArgumentNullException>(() => calculator.CalculateSum(null));
            }
        }

        [TestFixture]
        public class given_a_numeric_string
        {
            [Test]
            [TestCase(1)]
            [TestCase(2)]
            [TestCase(35)]
            public void it_should_return_the_number(int number)
            {
                int result = new Calculator().CalculateSum(number.ToString());
                Assert.That(result, Is.EqualTo(number));
            }
        }
    }
}
