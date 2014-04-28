using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PredictTheNumber;
using System.Diagnostics;
using System.Threading;

namespace PredictTheNumber.Tests
{
    [TestFixture]
    class Benchmarks
    {
        public PredictTheNumber predictTheNumber;
        public long[] testTargetNumbers;

        [SetUp]
        public void IntegrationTestSetup()
        {
            predictTheNumber = new PredictTheNumber();
            testTargetNumbers = new long[]{0,1,2,5,10,25,55,100,230,500,900,1500,3000,
                                           7000,12000,30000,50000,65636,131172,262444,
                                           524788,1049176,2097386,4200068,8389283,16782880,
                                           33557884,67112316,134218184,268447801,536883278,
                                           1073745276,2147718269};
        }

        [Test]
        public void CalculateRunTimeForPredeterminedValues()
        {

            long actualResult;
            long targetPosition;
            Stopwatch stopwatch;

            for (int i = 0; i < testTargetNumbers.Length; i++)
            {
                stopwatch = new Stopwatch();

                stopwatch.Start();
                targetPosition = testTargetNumbers[i];
                long stringLength = predictTheNumber.DetermineNeededStringLength(targetPosition);
                int numberOfTransforms = (int)predictTheNumber.NumberOfTransformations(targetPosition, stringLength);
                actualResult = predictTheNumber.DigitAfterTransform(numberOfTransforms);
                stopwatch.Stop();

                Console.WriteLine("Test for 2^" + i + " = " + testTargetNumbers[i] + " took " + stopwatch.ElapsedTicks + " ticks");
            }


            Assert.IsTrue(true);
        }
    }
}
