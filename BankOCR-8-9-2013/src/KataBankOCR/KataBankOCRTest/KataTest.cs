﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using KataBankOCR.Code;


namespace KataBankOCR.UnitTest
{

    [TestFixture]
    class KataTest
    {
        public KataCode _kataCode;
        
        private char[,] _OCR1 = new char[3, 3]
            {
                {' ',' ',' '},
                {' ',' ','|'},
                {' ',' ','|'}   
            };

        private char[,] _OCR2 = new char[3, 3]
            {
                {' ','_',' '},
                {' ','_','|'},
                {'|','_',' '}
            };
        private char[,] _OCR3 = new char[3, 3]
            {
                {' ','_',' '},
                {' ','_','|'},
                {' ','_','|'}
            };
        private char[,] _OCR4 = new char[3, 3]
            {
                {' ',' ',' '},
                {'|','_','|'},
                {' ',' ','|'},
            };
        private char[,] _OCR5 = new char[3, 3]
            {
                {' ','_',' '},
                {'|','_',' '},
                {' ','_','|'}
            };
        private char[,] _OCR6 = new char[3, 3]
            {
                {' ','_',' '},
                {'|','_',' '},
                {'|','_','|'}
            };
        private char[,] _OCR7 = new char[3, 3]
            {
                {' ','_',' '},
                {' ',' ','|'},
                {' ',' ','|'}
            };
        private char[,] _OCR8 = new char[3, 3]
            {
                {' ','_',' '},
                {'|','_','|'},
                {'|','_','|'}
            };
        private char[,] _OCR9 = new char[3, 3]
            {
                {' ','_',' '},
                {'|','_','|'},
                {' ','_','|'}
            };
        private char[,] _OCR0 = new char[3, 3]
            {
                {' ','_',' '},
                {'|',' ','|'},
                {'|','_','|'}
            };

        private char[][,] _ocrAccountNumberAllZeros = new char[9][,];

        [SetUp]
        public void SetupUnitTests()
        {
            _kataCode = new KataCode();
            
            for (int i = 0; i < 9; i++)
            {
                _ocrAccountNumberAllZeros[i] = _OCR0;
            }
        }

        [Test]
        public void OcrNumberIs1()
        {
            var actualResult = _kataCode.ConvertOCRtoDigit(_OCR1);
            var expectedResult = '1';
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void OcrNumberIs2()
        {
            var actualResult = _kataCode.ConvertOCRtoDigit(_OCR2);
            var expectedResult = '2';
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void OcrNumberIs3()
        {
            var actualResult = _kataCode.ConvertOCRtoDigit(_OCR3);
            var expectedResult = '3';
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void OcrNumberIs4()
        {
            var actualResult = _kataCode.ConvertOCRtoDigit(_OCR4);
            var expectedResult = '4';
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void OcrNumberIs5()
        {
            var actualResult = _kataCode.ConvertOCRtoDigit(_OCR5);
            var expectedResult = '5';
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void OcrNumberIs6()
        {
            var actualResult = _kataCode.ConvertOCRtoDigit(_OCR6);
            var expectedResult = '6';
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void OcrNumberIs7()
        {
            var actualResult = _kataCode.ConvertOCRtoDigit(_OCR7);
            var expectedResult = '7';
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void OcrNumberIs8()
        {
            var actualResult = _kataCode.ConvertOCRtoDigit(_OCR8);
            var expectedResult = '8';
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void OcrNumberIs9()
        {
            var actualResult = _kataCode.ConvertOCRtoDigit(_OCR9);
            var expectedResult = '9';
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void OcrNumberIs0()
        {
            var actualResult = _kataCode.ConvertOCRtoDigit(_OCR0);
            var expectedResult = '0';
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void RecognizeOcrAccountNumberWithAllZeros()
        {
            var actualResult = _kataCode.ConvertOcrAccountNumberToDigitAccountNumber(_ocrAccountNumberAllZeros);
            var expectedResult = "000000000";
            Assert.AreEqual(actualResult, expectedResult);
            

        }
    }
}