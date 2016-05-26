using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberSystemConverter
{
    public class RomanNumeralConverter
    {
        public RomanNumeralConverter()
        { }

        public string ConvertRomanNumeral(int number)
        {
            if (number < 1 || number >= 4000)
            {
                throw new IndexOutOfRangeException("The number supplied is out of the expected range (1 - 4000).");
            }

            var builder = new StringBuilder();

            var romanNumbers = Enum.GetValues(typeof(RomanNumeralsType)).Cast<RomanNumeralsType>().OrderByDescending(x => (int)x);
            while (number > 0)
            {
                RomanNumeralsType current = romanNumbers.First(x => (number - (int)x) >= 0);
                builder.Append(current.ToString());
                number -= (int)current;
            }
            return builder.ToString();
        }
    }
}