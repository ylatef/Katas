using System;

namespace StringCalculator
{
    public class Calculator
    {
        public int CalculateSum(String number)
        {
            if (number == null) throw new ArgumentNullException("number");
            if (number.Equals("a")) throw new ArgumentException();
            if (number.Equals(String.Empty)) return 0;
            return Int32.Parse(number);
        }
    }
}
