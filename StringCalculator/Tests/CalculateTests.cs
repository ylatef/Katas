using System;
using NUnit.Framework;
using Console;

namespace Tests
{
    [TestFixture]
    public class when_add_is_called
    {
        [TestFixture]
        public class given_an_empty_string
        {
            [Test]
            public void it_should_return_zero()
            {
                int result = new Calculator().Add(String.Empty);
                Assert.That(result, Is.EqualTo(0));
            }
        }
	}
}
