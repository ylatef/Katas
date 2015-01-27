using System;
using System.Linq;
using System.Xml;
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

        [Test]
        public void return_the_sum_given_two_numbers()
        {
            const int first = 1;
            const int second = 2;
            string numbers = CommaDelimit(new[] {first, second});
            int result = new Calculator().Add(numbers);
            Assert.That(result, Is.EqualTo(first+second));
        }

        [Test]
        public void return_the_sum_given_three_numbers()
        {
            const int first = 1;
            const int second = 2;
            const int third = 3;
            string numbers = CommaDelimit(new[] {first, second, third});
            int result = new Calculator().Add(numbers);
            Assert.That(result, Is.EqualTo(first+second+third));
        }

        [Test]
        public void sum_numbers_delimited_with_newlines()
        {
            int[] values = {3, 5, 12, 67};
            int result = new Calculator().Add(NewlineDelimit(values));
            Assert.That(result, Is.EqualTo(values.Sum()));
        }

        [Test]
        public void throw_an_exception_given_two_adjacent_delimiters()
        {
            Assert.Throws<FormatException>(() => new Calculator().Add("1,\n"));
        }

        [Test]
        public void allow_input_to_define_delimiter()
        {
            const int first = 1;
            const int second = 12;
            const int third = 3;
            string numberString = String.Format("//;\n{0};{1};{2}", first, second, third);
            int result = new Calculator().Add(numberString);
            Assert.That(result, Is.EqualTo(first+second+third));
        }

        [Test]
        public void throw_an_exception_given_a_negative_number()
        {
            Assert.Throws<ArgumentException>(() => new Calculator().Add("-1"));
        }

        [Test]
        public void report_the_value_given_a_negative_number()
        {
            const int negative = -5;
            var ex = Assert.Catch<Exception>(() => new Calculator().Add(negative.ToString()));
            Assert.That(ex.Message, 
                Is.StringContaining("negatives not allowed; received value " + negative));
        }

        private string NewlineDelimit(int[] numbers)
        {
            return BuildDelimitedString(numbers, "\n");
        }

        private string CommaDelimit(int[] numbers)
        {
            return BuildDelimitedString(numbers, ",");
        }

        private string BuildDelimitedString(int[] numbers, string delimiter)
        {
            if (numbers.Length == 0) return String.Empty;
            string numberString = numbers[0].ToString();
            for (int i = 1; i < numbers.Length; i++)
            {
                numberString += delimiter + numbers[i];
            }
            return numberString;
        }
    }
}
