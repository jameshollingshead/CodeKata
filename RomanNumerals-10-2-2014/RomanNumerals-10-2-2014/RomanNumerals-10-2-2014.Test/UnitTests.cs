using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RomanNumerals_10_2_2014;

namespace RomanNumerals_10_2_2014.Test
{
    [TestFixture]
    public class UnitTests
    {
        public RomanNumerals romanNumerals;
        
        int[] arabicNumbersToTest = {1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 14, 19, 20, 24, 40, 50, 90, 100, 
                                        400, 500, 900, 1000, 2473, 3000};
        string[] romanNumeralsToTest = { "I", "II", "III", "IV", "V", "VI", "VIII", "IX", "X", "XI", "XIV", "XIX",
                                       "XX", "XXIV", "XL", "L", "XC", "C", "CD", "D", "CM", "M", "MMCDLXXIII", "MMM"};

        [SetUp]
        public void TestSetup()
        {
            romanNumerals = new RomanNumerals();
            
        }

        [Test]
        public void ArabicNumbertoRomanNumeralConversion()
        {
            for(int i = 0; i < arabicNumbersToTest.Length; i++)
            {
                int input = arabicNumbersToTest[i];
                string expectedResult = romanNumeralsToTest[i];
                string actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

                Assert.AreEqual(expectedResult, actualResult);
            }
        }

        [Test]
        public void RomanNumeraltoArabicNumberConversion()
        {
            for(int i = 0; i < romanNumeralsToTest.Length; i++)
            {
                string input = romanNumeralsToTest[i];
                int expectedResult = arabicNumbersToTest[i];
                int actualResult = romanNumerals.ConvertRomanNumeralsToArabic(input);

                Assert.AreEqual(expectedResult, actualResult);
            }
        }

        
    }
}
