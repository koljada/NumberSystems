using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberSystemConverter.Tests
{
    [TestClass]
    public class RomanNumeralConverterUpperAndLowerBoundsUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Number_Greater_Than_FourThousand_Throws_IndexOutOfRangeException_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertRomanNumeral(4000);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Number_Less_Than_One_Throws_IndexOutOfRangeException_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertRomanNumeral(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Number_Zero_Throws_IndexOutOfRangeException_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertRomanNumeral(0);
        }
    }
}
