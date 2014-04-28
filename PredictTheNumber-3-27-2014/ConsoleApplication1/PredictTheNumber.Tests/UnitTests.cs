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
    public class UnitTests
    {
        public PredictTheNumber predictTheNumber;

        [SetUp]
        public void TestSetup()
        {
            predictTheNumber = new PredictTheNumber();
        }

        [Test]
        public void position1NeedsAStringOfLength2()
        {
            long targetPosition = 1;
            long expectedResult = 2;
            long actualResult;

            actualResult = predictTheNumber.DetermineNeededStringLength(targetPosition);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void position0NeedsAStringLengthOf1()
        {
            long targetPosition = 0;
            long expectedResult = 1;
            long actualResult;

            actualResult = predictTheNumber.DetermineNeededStringLength(targetPosition);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void position3NeedsAStringLengthOf4()
        {
            long targetPosition = 3;
            long expectedResult = 4;
            long actualResult;

            actualResult = predictTheNumber.DetermineNeededStringLength(targetPosition);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void position6NeedsAStringLengthOf8()
        {
            long targetPosition = 6;
            long expectedResult = 8;
            long actualResult;

            actualResult = predictTheNumber.DetermineNeededStringLength(targetPosition);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void position10NeedsAStringLengthOf16()
        {
            long targetPosition = 10;
            long expectedResult = 16;
            long actualResult;

            actualResult = predictTheNumber.DetermineNeededStringLength(targetPosition);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void position15NeedsAStringLengthOf16()
        {
            long targetPosition = 15;
            long expectedResult = 16;
            long actualResult;

            actualResult = predictTheNumber.DetermineNeededStringLength(targetPosition);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void position16NeedsAStringLengthOf32()
        {
            long targetPosition = 16;
            long expectedResult = 32;
            long actualResult;

            actualResult = predictTheNumber.DetermineNeededStringLength(targetPosition);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void position4NeedsAStringLengthOf8()
        {
            long targetPosition = 4;
            long expectedResult = 8;
            long actualResult;

            actualResult = predictTheNumber.DetermineNeededStringLength(targetPosition);

            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void position1NeedsToHave1Transformation()
        {
            long targetPosition = 1;
            long stringLength = 2;
            long expectedResult = 1;
            long actualResult;

            actualResult = predictTheNumber.NumberOfTransformations(targetPosition, stringLength);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void position0NeedsToHave0Transformation()
        {
            long targetPosition = 0;
            long stringLength = 1;
            long expectedResult = 0;
            long actualResult;

            actualResult = predictTheNumber.NumberOfTransformations(targetPosition, stringLength);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void position2NeedsToHave1Transformation()
        {
            long targetPosition = 2;
            long stringLength = 4;
            long expectedResult = 1;
            long actualResult;

            actualResult = predictTheNumber.NumberOfTransformations(targetPosition, stringLength);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void position3NeedsToHave2Transformation()
        {
            long targetPosition = 3;
            long stringLength = 4;
            long expectedResult = 2;
            long actualResult;

            actualResult = predictTheNumber.NumberOfTransformations(targetPosition, stringLength);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void position4NeedsToHave1Transformation()
        {
            long targetPosition = 4;
            long stringLength = 8;
            long expectedResult = 1;
            long actualResult;

            actualResult = predictTheNumber.NumberOfTransformations(targetPosition, stringLength);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void position5NeedsToHave2Transformation()
        {
            long targetPosition = 5;
            long stringLength = 8;
            long expectedResult = 2;
            long actualResult;

            actualResult = predictTheNumber.NumberOfTransformations(targetPosition, stringLength);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void position6NeedsToHave2Transformation()
        {
            long targetPosition = 6;
            long stringLength = 8;
            long expectedResult = 2;
            long actualResult;

            actualResult = predictTheNumber.NumberOfTransformations(targetPosition, stringLength);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void position7NeedsToHave3Transformation()
        {
            long targetPosition = 7;
            long stringLength = 8;
            long expectedResult = 3;
            long actualResult;

            actualResult = predictTheNumber.NumberOfTransformations(targetPosition, stringLength);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void If0TransformationNumberIs0()
        {
            int numberOfTransformations = 0;
            long expectedResult = 0;
            long actualResult;

            actualResult = predictTheNumber.DigitAfterTransform(numberOfTransformations);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void If1TransformationNumberIs1()
        {
            int numberOfTransformations = 1;
            long expectedResult = 1;
            long actualResult;

            actualResult = predictTheNumber.DigitAfterTransform(numberOfTransformations);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void If2TransformationNumberIs2()
        {
            int numberOfTransformations = 2;
            long expectedResult = 2;
            long actualResult;

            actualResult = predictTheNumber.DigitAfterTransform(numberOfTransformations);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void If3TransformationNumberIs0()
        {
            int numberOfTransformations = 3;
            long expectedResult = 0;
            long actualResult;

            actualResult = predictTheNumber.DigitAfterTransform(numberOfTransformations);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void If4TransformationNumberIs1()
        {
            int numberOfTransformations = 4;
            long expectedResult = 1;
            long actualResult;

            actualResult = predictTheNumber.DigitAfterTransform(numberOfTransformations);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void FileContentsIsAccessedProperly()
        {
            string[] expectedResult = { "0", "5", "101", "25684" };
            string[] actualResult;

            actualResult = predictTheNumber.GetFileContents("testfile.txt");

            Assert.AreEqual(expectedResult[0], actualResult[0]);
            Assert.AreEqual(expectedResult[1], actualResult[1]);
            Assert.AreEqual(expectedResult[2], actualResult[2]);
            Assert.AreEqual(expectedResult[3], actualResult[3]);
        }

        [Test]
        public void String123ReturnsLong123()
        {
            string input = "123";
            long expectedResult = 123;
            long actualResult;

            actualResult = predictTheNumber.ConvertStringBasedNumberToLong(input);

            Assert.AreEqual(expectedResult, actualResult);
        }
       
    }
}
