using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InterruptedBubbleSort;

namespace InterruptedBubbleSort.Test
{
    [TestFixture]
    public class UnitTests
    {
        BubbleSort bubbleSort;

        [SetUp]
        public void TestSetup()
        {
            bubbleSort = new BubbleSort();
        }
        
        [Test]
        public void NumberOfSorts1()
        {
            int[] inputNumbers = { 1, 4, 3, 5, 7, 9, 8 };
            int numberOfPasses = 1;
            int[] expectedResult = { 1, 3, 4, 5, 7, 8, 9 };
            int[] actualResult;

            actualResult = bubbleSort.PerformNBubbleSorts(inputNumbers, numberOfPasses);

            for(int i = 0; i<inputNumbers.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [Test]
        public void NumberOfSorts2()
        {
            int[] inputNumbers = { 59, 68, 55, 31, 73, 4, 1, 25, 26, 19, 60, 0};
            int numberOfPasses = 2;
            int[] expectedResult = { 55, 31, 59, 4, 1, 25, 26, 19, 60, 0, 68, 73 };
            int[] actualResult;

            actualResult = bubbleSort.PerformNBubbleSorts(inputNumbers, numberOfPasses);

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [Test]
        public void NumberOfSorts6()
        {
            int[] inputNumbers = { 54, 46, 0, 34, 15, 48, 47, 53, 25, 18, 50, 5, 21, 76, 62, 48, 74, 1, 43, 74, 78, 29 };
            int numberOfPasses = 6;
            int[] expectedResult = { 0, 15, 25, 18, 34, 5, 21, 46, 47, 48, 48, 1, 43, 50, 53, 29, 54, 62, 74, 74, 76, 78};
            int[] actualResult;

            actualResult = bubbleSort.PerformNBubbleSorts(inputNumbers, numberOfPasses);

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
