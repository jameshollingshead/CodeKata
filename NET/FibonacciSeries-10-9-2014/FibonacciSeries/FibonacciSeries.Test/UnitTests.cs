using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FibonacciSeries;

namespace FibonacciSeries.Test
{
    [TestFixture]
    public class UnitTests
    {
        public FibonacciNumber fibonacciNumber;

        [SetUp]
        public void TestSetup()
        {
            fibonacciNumber = new FibonacciNumber();
        }

        [Test]
        public void Fib0is0()
        {
            int input = 0;
            int expectedResult = 0;
            int actualResult;

            actualResult = fibonacciNumber.CalculateFibonacciNumber(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Fib1is1()
        {
            int input = 1;
            int expectedResult = 1;
            int actualResult;

            actualResult = fibonacciNumber.CalculateFibonacciNumber(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Fib2is1()
        {
            int input = 2;
            int expectedResult = 1;
            int actualResult;

            actualResult = fibonacciNumber.CalculateFibonacciNumber(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Fib3is2()
        {
            int input = 3;
            int expectedResult = 2;
            int actualResult;

            actualResult = fibonacciNumber.CalculateFibonacciNumber(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Fib4is3()
        {
            int input = 4;
            int expectedResult = 3;
            int actualResult;

            actualResult = fibonacciNumber.CalculateFibonacciNumber(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Fib5is5()
        {
            int input = 5;
            int expectedResult = 5;
            int actualResult;

            actualResult = fibonacciNumber.CalculateFibonacciNumber(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
