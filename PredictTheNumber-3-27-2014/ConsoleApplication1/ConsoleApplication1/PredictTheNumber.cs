using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("PredictTheNumber.Tests")]
namespace PredictTheNumber
{
    public class PredictTheNumber
    {
        internal long DetermineNeededStringLength(long targetPosition)
        {
            long result;
            int powerOfTwo;

            //Since Log2(0) = infinity, we have to treat this as an edge case whose answer is 1
            if (targetPosition == 0)
            {
                result = 1;
            }
            else
            {
                //adjust target position by 1 so we can use "normal people" (counting numbers start at 1) math.
                targetPosition += 1;

                powerOfTwo = (int)Math.Ceiling(Math.Log(targetPosition, 2));
                result = (long)Math.Pow(2, powerOfTwo);
            }

            return result;
        }



        internal long NumberOfTransformations(long targetPosition, long stringLength)
        {
            long result;
            long halfStringLength = stringLength/2;
            long newTarget;

            if (targetPosition <= 0)
            {
                //Position 0 is the origin position. No new transformations will ever take place after this point.
                result = 0;
            }
            else if (targetPosition < halfStringLength)
            {
                //If the number is in the first half of the string, it will be identical
                //to the string from the transformation below it, so there is no
                //transformation to add to the total 
                //(ie position 2 on a string length of 8 will be exactly the same as position 2 on a string length of 4)
                result = NumberOfTransformations(targetPosition, halfStringLength);
            }
            else
            {
                //example - position 6 on a string of length 8 is one transformation away from position 2 on a string of length 4
                newTarget = targetPosition - halfStringLength;
                result = NumberOfTransformations(newTarget, halfStringLength);
                result++;
            }

            return result;
        }

        internal long DigitAfterTransform(long numberOfTransformations)
        {
            long result;

            result = numberOfTransformations % 3;

            return result;
        }

        internal string[] GetFileContents(string fileName)
        {
            string[] result;

            result = System.IO.File.ReadAllLines(fileName);

            return result;
        }

        internal long ConvertStringBasedNumberToLong(string input)
        {
            long result;

            result = Convert.ToInt64(input);

            return result;
        }

        internal long ValueOfDigitAtSpecifiedLocation(long targetPosition)
        {
            long result;
            long lengthOfStringNeeded;
            long numberOfTransformationsNeeded;
            
            lengthOfStringNeeded = DetermineNeededStringLength(targetPosition);
            numberOfTransformationsNeeded = NumberOfTransformations(targetPosition, lengthOfStringNeeded);
            result = DigitAfterTransform(numberOfTransformationsNeeded);
            
            return result;
        }
    }
}
