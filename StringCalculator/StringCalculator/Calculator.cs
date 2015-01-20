using System;

namespace StringCalculator
{
    public class Calculator
    {
        public int CalculateSum(String number)
        {
            if (number == null) throw new ArgumentNullException("number");
            if (number.Equals(String.Empty)) return 0;

            int result;
            if (Int32.TryParse(number, out result))
            {
                return result;
            }
            
            throw new ArgumentException(
                "Input must only contain numeric characters and commas.\n",
                String.Format("Input was {0}.", number));
        }
    }
}
