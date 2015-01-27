using System;
using Console;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class add_should
    {
        [Test]
        public void return_zero_given_an_empty_string()
        {
            int result = new Calculator().Add(String.Empty);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(1)]
        [TestCase(35)]
        public void return_the_number_given_a_numeric_string(int number)
        {
            int result = new Calculator().Add(number.ToString()); 
            Assert.That(result, Is.EqualTo(number));
        }
    }
}
