using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PredictTheNumber;

namespace PredictTheNumber.Tests
{
    
    [TestFixture]
    class IntegrationTests
    {
        public PredictTheNumber predictTheNumber;

        [SetUp]
        public void IntegrationTestSetup()
        {
            predictTheNumber = new PredictTheNumber();
        }

        [Test]
        public void Position0is0()
        {
            //string is 0
            long expectedResult = 0;
            long actualResult;
            long targetPosition = 0;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position1is1()
        {
            //string is 01
            long expectedResult = 1;
            long actualResult;
            long targetPosition = 1;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position2is1()
        {
            //string is 0112
            long expectedResult = 1;
            long actualResult;
            long targetPosition = 2;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position3is2()
        {
            //string is 0112
            long expectedResult = 2;
            long actualResult;
            long targetPosition = 3;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position4is1()
        {
            //string is 01121220
            long expectedResult = 1;
            long actualResult;
            long targetPosition = 4;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position5is2()
        {
            //string is 01121220
            long expectedResult = 2;
            long actualResult;
            long targetPosition = 5;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position6is2()
        {
            //string is 01121220
            long expectedResult = 2;
            long actualResult;
            long targetPosition = 6;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position7is0()
        {
            //string is 01121220
            long expectedResult = 0;
            long actualResult;
            long targetPosition = 7;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position8is1()
        {
            //string is 0112122012202001
            long expectedResult = 1;
            long actualResult;
            long targetPosition = 8;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position9is2()
        {
            //string is 0112122012202001
            long expectedResult = 2;
            long actualResult;
            long targetPosition = 9;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position10is2()
        {
            //string is 0112122012202001
            long expectedResult = 2;
            long actualResult;
            long targetPosition = 10;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position11is0()
        {
            //string is 0112122012202001
            long expectedResult = 0;
            long actualResult;
            long targetPosition = 11;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position12is2()
        {
            //string is 0112122012202001
            long expectedResult = 2;
            long actualResult;
            long targetPosition = 12;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position13is0()
        {
            //string is 0112122012202001
            long expectedResult = 0;
            long actualResult;
            long targetPosition = 13;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position14is0()
        {
            //string is 0112122012202001
            long expectedResult = 0;
            long actualResult;
            long targetPosition = 14;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position15is1()
        {
            //string is 0112122012202001
            long expectedResult = 1;
            long actualResult;
            long targetPosition = 15;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position16is1()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 1;
            long actualResult;
            long targetPosition = 16;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position17is2()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 2;
            long actualResult;
            long targetPosition = 17;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position18is2()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 2;
            long actualResult;
            long targetPosition = 18;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position19is0()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 0;
            long actualResult;
            long targetPosition = 19;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position20is2()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 2;
            long actualResult;
            long targetPosition = 20;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position21is0()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 0;
            long actualResult;
            long targetPosition = 21;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position22is0()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 0;
            long actualResult;
            long targetPosition = 22;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position23is1()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 1;
            long actualResult;
            long targetPosition = 23;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position24is2()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 2;
            long actualResult;
            long targetPosition = 24;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position25is0()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 0;
            long actualResult;
            long targetPosition = 25;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position26is0()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 0;
            long actualResult;
            long targetPosition = 26;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position27is1()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 1;
            long actualResult;
            long targetPosition = 27;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position28is0()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 0;
            long actualResult;
            long targetPosition = 28;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position29is1()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 1;
            long actualResult;
            long targetPosition = 29;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position30is1()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 1;
            long actualResult;
            long targetPosition = 30;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position31is2()
        {
            //string is 01121220122020011220200120010112
            long expectedResult = 2;
            long actualResult;
            long targetPosition = 31;
            long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
            int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
            long targetDigit = predictTheNumber.DigitAfterTransform(numberOfTransforms);

            actualResult = targetDigit;
            Assert.AreEqual(expectedResult, actualResult);
        }

        
    }
}
