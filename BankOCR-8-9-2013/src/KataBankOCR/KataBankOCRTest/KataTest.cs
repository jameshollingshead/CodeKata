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

        [SetUp]
        public void SetupUnitTests()
        {
            _kataCode = new KataCode();
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
    }
}