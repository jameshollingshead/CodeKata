using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using KataBankOCR.Code;
using KataBankOCR.Shared;


namespace KataBankOCR.UnitTest
{

    [TestFixture]
    class KataTest
    {
        public KataCode _kataCode;
        private OcrConstants ocrConstants = new OcrConstants();
        private string[][] _ocrAccountNumberAllZeros = new string[9][];

        private string[] _dummyFileInput = 
            {
                " _  _  _  _  _  _  _  _  _ ",
                "| || || || || || || || || |",
                "|_||_||_||_||_||_||_||_||_|",
                "                           ",
                "                           ",
                "  |  |  |  |  |  |  |  |  |",
                "  |  |  |  |  |  |  |  |  |",
                "                           "
            };

        [SetUp]
        public void SetupUnitTests()
        {
            _kataCode = new KataCode();
            var ocr0 = ocrConstants.Ocr0;
            
            for (int i = 0; i < 9; i++)
            {
                _ocrAccountNumberAllZeros[i] = ocr0;
            }
        }

        [Test]
        public void OcrNumberIs1()
        {
            var ocr1 = ocrConstants.Ocr1;
            var actualResult = _kataCode.ConvertOCRtoDigit(ocr1);
            var expectedResult = '1';
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void OcrNumberIs2()
        {
            var ocr2 = ocrConstants.Ocr2;
            var actualResult = _kataCode.ConvertOCRtoDigit(ocr2);
            var expectedResult = '2';
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void OcrNumberIs3()
        {
            var ocr3 = ocrConstants.Ocr3;
            var actualResult = _kataCode.ConvertOCRtoDigit(ocr3);
            var expectedResult = '3';
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void OcrNumberIs4()
        {
            var ocr4 = ocrConstants.Ocr4;
            var actualResult = _kataCode.ConvertOCRtoDigit(ocr4);
            var expectedResult = '4';
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void OcrNumberIs5()
        {
            var ocr5 = ocrConstants.Ocr5;
            var actualResult = _kataCode.ConvertOCRtoDigit(ocr5);
            var expectedResult = '5';
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void OcrNumberIs6()
        {
            var ocr6 = ocrConstants.Ocr6;
            var actualResult = _kataCode.ConvertOCRtoDigit(ocr6);
            var expectedResult = '6';
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void OcrNumberIs7()
        {
            var ocr7 = ocrConstants.Ocr7;
            var actualResult = _kataCode.ConvertOCRtoDigit(ocr7);
            var expectedResult = '7';
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void OcrNumberIs8()
        {
            var ocr8 = ocrConstants.Ocr8;
            var actualResult = _kataCode.ConvertOCRtoDigit(ocr8);
            var expectedResult = '8';
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void OcrNumberIs9()
        {
            var ocr9 = ocrConstants.Ocr9;
            var actualResult = _kataCode.ConvertOCRtoDigit(ocr9);
            var expectedResult = '9';
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void OcrNumberIs0()
        {
            var ocr0 = ocrConstants.Ocr0;
            var actualResult = _kataCode.ConvertOCRtoDigit(ocr0);
            var expectedResult = '0';
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void RecognizeOcrAccountNumberWithAllZeros()
        {
            var actualResult = _kataCode.ConvertOcrAccountNumberToDigitAccountNumber(_ocrAccountNumberAllZeros);
            var expectedResult = "000000000";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void OcrAccountNumberOfAllZerosBecomesStringOfZeros()
        {
            string[] testInput = 
            {
                " _  _  _  _  _  _  _  _  _ ",
                "| || || || || || || || || |",
                "|_||_||_||_||_||_||_||_||_|"
            };

            var actualResult = _kataCode.OcrAccountStringToDigitalAccountNumber(testInput);
            var expectedResult = "000000000";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void EightLineAccountNumberFileWithAllZeroOcrAccountNumberBecomesStringOfZeros()
        {
            var actualResult = _kataCode.TurnFileContentsIntoDigitalAccountNumbers(_dummyFileInput);
            var expectedResult = "000000000";
            Assert.AreEqual(expectedResult, actualResult[0]);
        }

        [Test]
        public void ReadInputFromFileAndReturnAccountNumberOfAllZeros()
        {
            string dummyFileName = "testfile.txt";
            var actualResult = _kataCode.TurnFileIntoDigitalAccountNumbers(dummyFileName);
            var expectedResult = "000000000";
            Assert.AreEqual(expectedResult, actualResult[0]);
        }
        
    }
}