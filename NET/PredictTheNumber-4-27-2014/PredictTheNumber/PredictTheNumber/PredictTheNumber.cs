using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


[assembly: InternalsVisibleTo("PredictTheNumber.UnitTests")]
namespace PredictTheNumber
{
    public class PredictTheNumber
    {
        internal string GetCompletedNumberString(long targetPosition)
        {
            string result;
            long minimumStringLength = targetPosition + 1; //Counting is 0 based, so we need to correct for this
            string numberString = "0";

            while(numberString.Length < minimumStringLength)
            {
                numberString = PerformTransformOnNumberString(numberString);
            }

            result = numberString;
            
            return result;
        }

        internal string PerformTransformOnNumberString(string input)
        {
            string result = input;
            string tmpLastHalf;

            tmpLastHalf = input;
            tmpLastHalf = tmpLastHalf.Replace('0', 'B');
            tmpLastHalf = tmpLastHalf.Replace('1', 'C');
            tmpLastHalf = tmpLastHalf.Replace('2', 'A');
            tmpLastHalf = tmpLastHalf.Replace('A', '0');
            tmpLastHalf = tmpLastHalf.Replace('B', '1');
            tmpLastHalf = tmpLastHalf.Replace('C', '2');

            result += tmpLastHalf;
            return result;
        }

        internal char GetTargetNumberInString(string numberString, int targetPosition)
        {
            char result;

            result = numberString[targetPosition];

            return result;
        }
    }
}
