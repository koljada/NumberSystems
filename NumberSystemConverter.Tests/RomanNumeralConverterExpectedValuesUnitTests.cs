using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberSystemConverter.Tests
{
    [TestClass]
    public class RomanNumeralConverterExpectedValuesUnitTests
    {
        [TestMethod]
        public void Number_Equal_One_Expected_Result_I_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(1);

            Assert.AreEqual(result, "I");

        }

        [TestMethod]
        public void Number_Equal_ThreeThousand_Expected_Result_MMM_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(3000);

            Assert.AreEqual(result, "MMM");

        }

        [TestMethod]
        public void Number_Equal_55_Expected_Result_LV_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(55);

            Assert.AreEqual(result, "LV");
        }

        [TestMethod]
        public void Number_Equal_100_Expected_Result_C_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(100);

            Assert.AreEqual(result, "C");
        }

        [TestMethod]
        public void Number_Equal_500_Expected_Result_D_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(500);

            Assert.AreEqual(result, "D");
        }

        [TestMethod]
        public void Number_Equal_599_Expected_Result_DLXXXXVIIII_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(599);

            Assert.AreEqual(result, "DXCIX");
        }

        [TestMethod]
        public void Number_Equal_2013_Expected_Result_MMXIII_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(2013);

            Assert.AreEqual(result, "MMXIII");
        }

        [TestMethod]
        public void Number_Equal_4_Expected_Result_IV_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(4);

            Assert.AreEqual(result, "IV");
        }

        [TestMethod]
        public void Number_Equal_9_Expected_Result_IX_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(9);

            Assert.AreEqual(result, "IX");
        }

        [TestMethod]
        public void Number_Equal_1499_Expected_Result_MCDXCIX_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(1499);

            Assert.AreEqual(result, "MCDXCIX");
        }

        [TestMethod]
        public void Number_Equal_963_Expected_Result_CMLXIII_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            var result = converter.ConvertRomanNumeral(963);

            Assert.AreEqual(result, "CMLXIII");
        }
    }
}
