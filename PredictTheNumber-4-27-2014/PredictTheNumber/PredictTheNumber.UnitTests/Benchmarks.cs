using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PredictTheNumber;
using System.Diagnostics;
using System.Threading;

namespace PredictTheNumber.UnitTests
{
    [TestFixture]
    class Benchmarks
    {
        public PredictTheNumber predictTheNumber;
        public int[] testTargetNumbers;

        [SetUp]
        public void IntegrationTestSetup()
        {
            predictTheNumber = new PredictTheNumber();
            testTargetNumbers = new int[]{0,1,2,5,10,25,55,100,230,500,900,1500,3000,
                                           7000,12000,30000,50000,65636,131172,262444,
                                           524788,1049176,2097386,4200068,8389283,16782880,
                                           33557884,67112316,134218184,268447801,536883278,
                                           1073745276};
        }

        [Test]
        public void CalculateRunTimeForPredeterminedValues()
        {

            char actualResult;
            int targetPosition;
            string numberString;
            Stopwatch stopwatch;

            for (int i = 0; i < testTargetNumbers.Length; i++)
            {
                stopwatch = new Stopwatch();

                try
                {
                    stopwatch.Start();
                    targetPosition = testTargetNumbers[i];
                    numberString = predictTheNumber.GetCompletedNumberString(targetPosition);
                    actualResult = predictTheNumber.GetTargetNumberInString(numberString, targetPosition);
                    stopwatch.Stop();
                    Console.WriteLine("Test for 2^" + i + " = " + testTargetNumbers[i] + " took " + 
                        stopwatch.ElapsedTicks + " ticks = " + stopwatch.ElapsedMilliseconds + " milliseconds");
                }
                catch(OutOfMemoryException ex)
                {
                    Console.WriteLine("Test for 2^" + i + " = " + testTargetNumbers[i] + " - Out Of Memory Exception");
                }

                
            }


            Assert.IsTrue(true);
        }
    }
}
