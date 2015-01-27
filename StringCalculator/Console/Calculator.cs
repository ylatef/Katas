using System;

namespace Console
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (numbers.Equals(String.Empty)) return 0;
            return Int32.Parse(numbers);
        }
    }
}
