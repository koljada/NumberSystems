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
            if (number < 1 || number > 3000)
            {
                throw new IndexOutOfRangeException("The number supplied is out of the expected range (1 - 3000).");
            }

            var builder = new StringBuilder();

            //iterate through the list, starting with the highest value
            foreach (RomanNumeralsType currentPair in Enum.GetValues(typeof(RomanNumeralsType)).Cast<RomanNumeralsType>().Reverse())
            {
                int current_number = (int)(currentPair);

                while (number >= current_number)
                {//...number is greater than or equal to the current value so store the roman numeral and decrement it's value 
                    builder.Append(currentPair.ToString());
                    number -= current_number;
                }
            }

            return builder.ToString();
        }
    }
}