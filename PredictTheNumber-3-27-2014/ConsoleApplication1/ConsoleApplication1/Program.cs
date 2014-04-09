using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            PredictTheNumber predictTheNumber = new PredictTheNumber();
            string filename = args[0];
            string[] fileContents;
            long positionToFind;
            long digitToPrint;


            fileContents = predictTheNumber.GetFileContents(filename);

            for(int i = 0; i < fileContents.Length; i++)
            {
                positionToFind = predictTheNumber.ConvertStringBasedNumberToLong(fileContents[i]);
                digitToPrint = predictTheNumber.ValueOfDigitAtSpecifiedLocation(positionToFind);
                Console.WriteLine(digitToPrint);
            }
        }
    }
}
