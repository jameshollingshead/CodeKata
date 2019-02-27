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
            string fileName = args[0];
            string[] fileContents;
            int numberInSeries;
            int calculatedFibonacciNumber;
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            fileContents = GetFileContents(fileName);

            for(int i = 0; i<fileContents.Length; i++)
            {
                numberInSeries = Convert.ToInt32(fileContents[i]);
                calculatedFibonacciNumber = fibonacciNumber.CalculateFibonacciNumber(numberInSeries);
                Console.WriteLine(calculatedFibonacciNumber);
            }



        }

        private static string[] GetFileContents(string fileName)
        {
            string[] result;

            result = System.IO.File.ReadAllLines(fileName);

            return result;
        }

        public int CalculateFibonacciNumber(int input)
        {
            int previousFibNumber = 0;
            int currentFibNumber = 1;
            int tmp;
            int result;

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
