using System;
using System.Linq;

namespace Console
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return 0;
            string[] splitNumbers = numbers.Split(new []{','}, StringSplitOptions.None);
            return splitNumbers.Sum(number => Int32.Parse(number));
        }
    }
}
