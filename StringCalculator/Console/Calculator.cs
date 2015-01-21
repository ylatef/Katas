using System;

namespace Console
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return 0;
            int index = numbers.IndexOf(",");
            if (index > -1)
            {
                string[] splitNumbers = numbers.Split(new []{','}, StringSplitOptions.None);
                int result = 0;
                foreach (string number in splitNumbers)
                {
                    result += Int32.Parse(number);
                }
                return result;
            }
            return Int32.Parse(numbers);
        }
    }
}
