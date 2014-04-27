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
        public void String0ShouldReturn01()
        {
            string input = "0";
            string expectedResult = "01";
            string actualResult = predictTheNumber.PerformTransformOnNumberString(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void String01ShouldReturn0112()
        {
            string input = "01";
            string expectedResult = "0112";
            string actualResult = predictTheNumber.PerformTransformOnNumberString(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void String0112ShouldReturn01121220()
        {
            string input = "0112";
            string expectedResult = "01121220";
            string actualResult = predictTheNumber.PerformTransformOnNumberString(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position0ShouldReturn0()
        {
            long targetPosition = 0;
            string expectedResult = "0";
            string actualResult = predictTheNumber.GetCompletedNumberString(targetPosition);

            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [Test]
        public void Position1ShouldReturn01()
        {
            long targetPosition = 1;
            string expectedResult = "01";
            string actualResult = predictTheNumber.GetCompletedNumberString(targetPosition);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position3ShouldReturn0112()
        {
            long targetPosition = 3;
            string expectedResult = "0112";
            string actualResult = predictTheNumber.GetCompletedNumberString(targetPosition);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Position5ShouldReturn01121220()
        {
            long targetPosition = 5;
            string expectedResult = "01121220";
            string actualResult = predictTheNumber.GetCompletedNumberString(targetPosition);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
