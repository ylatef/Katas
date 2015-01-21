using System;
using System.Linq;
using System.Runtime.ExceptionServices;
using NUnit.Framework;
using Console;

namespace Tests
{
    [TestFixture]
    public class calculator_should
    {
        [Test]
        public void return_zero_given_an_empty_string()
        {
            int result = new Calculator().Add(String.Empty);
            Assert.That(result, Is.EqualTo(0));
        }
        
        [Test]
        public void return_the_parsed_value_given_a_numeric_string()
        {
            const int number = 1;
            int result = new Calculator().Add(number.ToString());
            Assert.That(result, Is.EqualTo(number));
        }

        [Test]
        [TestCase(new[] {1, 15, 3, 4})]
        public void return_the_sum_given_many_numbers(int[] numbers)
        {
            int result = new Calculator().Add(NumbersAsString(numbers));
            Assert.That(result, Is.EqualTo(numbers.Sum()));
        }

        private string NumbersAsString(int[] numbers)
        {
            if (numbers.Length == 0) return String.Empty;
            string numbersString = numbers[0].ToString();
            for (int i = 1; i < numbers.Length; i++)
            {
                numbersString += "," + numbers[i];
            }

            return numbersString;
        }
    }
}
