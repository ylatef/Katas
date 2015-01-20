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
    }
}
