using System;

namespace StringCalculator
{
    public class Calculator
    {
        public int CalculateSum(String number)
        {
            if (String.IsNullOrEmpty(number)) return 0;

            return Int32.Parse(number);
        }
    }
}
