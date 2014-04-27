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

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '0')
                {
                    result += "1";
                }
                if (input[i] == '1')
                {
                    result += "2";
                }
                if (input[i] == '2')
                {
                    result += "0";
                }

            }

                return result;
        }
    }
}
