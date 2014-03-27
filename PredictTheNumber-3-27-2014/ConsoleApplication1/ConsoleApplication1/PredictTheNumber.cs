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
        internal long DetermineNeededStringLength(int targetPosition)
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
    }
}
