using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    public class FibonacciNumber
    {
        static void Main(string[] args)
        {
        }

        public int CalculateFibonacciNumber(int input)
        {
            int previousFibNumber = 0;
            int currentFibNumber = 1;
            int tmp;
            int result;

            //Special Cases
            if (input == 0)
                result = 0;
            else if (input == 1)
                result = 1;
            else
            {
                for (int i = 2; i <= input; i++)
                {
                    tmp = previousFibNumber + currentFibNumber;
                    previousFibNumber = currentFibNumber;
                    currentFibNumber = tmp;
                }
                result = currentFibNumber;
            }

            
            return result;

        }
    }
}
