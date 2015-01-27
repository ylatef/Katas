using System;
using System.Linq;

namespace Console
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (numbers.Equals(String.Empty)) return 0;
            var splitNumbers = Split(numbers);
            return splitNumbers.Sum(number => Parse(number));
        }

        private int Parse(string number)
        {
            var value = Int32.Parse(number);
            if (value < 0) throw new ArgumentException(
                "negatives not allowed; received value " + number);
            return value;
        }

        private string[] Split(string numbers)
        {
            char[] delimiters = {',', '\n'};
            if (numbers.StartsWith("//"))
            {
                int firstLineEnd = numbers.IndexOf('\n');
                delimiters = new[] {numbers[2]};
                numbers = numbers.Substring(firstLineEnd + 1);
            }
            string[] splitNumbers = numbers.Split(delimiters);
            return splitNumbers;
        }
    }
}
