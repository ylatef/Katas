using System;
using NUnit.Framework;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestFixture]
    public class when_calculate_is_called
    {
        private static readonly Calculator Calculator = new Calculator();
        
        [TestFixture]
        public class given_an_empty_string
        {
            
            [Test]
            public void it_should_return_zero()
            {
                int result = Calculator.CalculateSum(String.Empty);
                Assert.That(result, Is.EqualTo(0));
            }
        }

        [TestFixture]
        public class given_a_null_string
        {
            [Test]
            public void it_should_throw_an_argument_null_exception()
            {
                Assert.Throws<ArgumentNullException>(() => Calculator.CalculateSum(null));
            }

            [Test]
            public void it_should_alert_the_user()
            {
                var ex = Assert.Catch<Exception>(() => Calculator.CalculateSum(null));
                Assert.That(ex.Message, Is.StringContaining("number"));
            }
        }

        [TestFixture]
        public class given_an_invalid_string
        {
            private const string CalculatorInput = "bcde*";

            [Test]
            public void it_should_throw_an_argument_exception()
            {
                Assert.Throws<ArgumentException>(() => CalculateSum());
            }

            [Test]
            public void it_should_alert_the_user()
            {
                var ex = Assert.Catch<Exception>(() => CalculateSum());
                Assert.That(ex.Message,
                    Is.StringStarting("Input must only contain numeric characters and commas"));
            }

            [Test]
            public void it_should_report_the_input()
            {
                var ex = Assert.Catch<Exception>(() => CalculateSum());
                Assert.That(ex.Message, Is.StringContaining(CalculatorInput));
            }

            private int CalculateSum()
            {
                return Calculator.CalculateSum(CalculatorInput);
            }
        }
            
        [TestFixture]
        public class given_a_numeric_string
        {
            [Test]
            [TestCase(1)]
            [TestCase(35)]
            public void it_should_return_the_number(int number)
            {
                int result = Calculator.CalculateSum(number.ToString());
                Assert.That(result, Is.EqualTo(number));
            }
        }
    }
}
