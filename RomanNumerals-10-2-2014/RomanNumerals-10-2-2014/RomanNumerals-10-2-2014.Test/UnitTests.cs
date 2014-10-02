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

        [SetUp]
        public void TestSetup()
        {
            romanNumerals = new RomanNumerals();
        }

        [Test]
        public void ArabicNumber1GivesRomanNumeralI()
        {
            int input = 1;
            string expectedResult = "I";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber2GivesRomanNumeralII()
        {
            int input = 2;
            string expectedResult = "II";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
