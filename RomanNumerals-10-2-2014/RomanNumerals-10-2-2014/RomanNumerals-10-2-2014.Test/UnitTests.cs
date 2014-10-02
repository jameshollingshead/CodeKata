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

        [Test]
        public void ArabicNumber3GivesRomanNumeralIII()
        {
            int input = 3;
            string expectedResult = "III";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber4GivesRomanNumeralIV()
        {
            int input = 4;
            string expectedResult = "IV";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber5GivesRomanNumeralV()
        {
            int input = 5;
            string expectedResult = "V";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber6GivesRomanNumeralVI()
        {
            int input = 6;
            string expectedResult = "VI";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber8GivesRomanNumeralVIII()
        {
            int input = 8;
            string expectedResult = "VIII";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber9GivesRomanNumeralIX()
        {
            int input = 9;
            string expectedResult = "IX";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber10GivesRomanNumeralX()
        {
            int input = 10;
            string expectedResult = "X";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber11GivesRomanNumeralXI()
        {
            int input = 11;
            string expectedResult = "XI";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber14GivesRomanNumeralXIV()
        {
            int input = 14;
            string expectedResult = "XIV";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber19GivesRomanNumeralXIX()
        {
            int input = 19;
            string expectedResult = "XIX";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber20GivesRomanNumeralXX()
        {
            int input = 20;
            string expectedResult = "XX";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber24GivesRomanNumeralXXIV()
        {
            int input = 24;
            string expectedResult = "XXIV";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber40GivesRomanNumeralXL()
        {
            int input = 40;
            string expectedResult = "XL";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber50GivesRomanNumeralL()
        {
            int input = 50;
            string expectedResult = "L";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber90GivesRomanNumeralXC()
        {
            int input = 90;
            string expectedResult = "XC";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber100GivesRomanNumeralC()
        {
            int input = 100;
            string expectedResult = "C";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber400GivesRomanNumeralCD()
        {
            int input = 400;
            string expectedResult = "CD";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber500GivesRomanNumeralD()
        {
            int input = 500;
            string expectedResult = "D";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber900GivesRomanNumeralCM()
        {
            int input = 900;
            string expectedResult = "CM";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber1000GivesRomanNumeralM()
        {
            int input = 1000;
            string expectedResult = "M";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber2473GivesRomanNumeralMMCDLXXIII()
        {
            int input = 2473;
            string expectedResult = "MMCDLXXIII";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArabicNumber3000GivesRomanNumeralMMM()
        {
            int input = 3000;
            string expectedResult = "MMM";
            string actualResult;

            actualResult = romanNumerals.ConvertArabicToRomanNumerals(input);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
