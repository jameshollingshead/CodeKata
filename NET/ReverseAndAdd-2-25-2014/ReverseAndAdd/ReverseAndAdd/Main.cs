using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndAdd
{
    class ReverseAndAddMain
    {
        static void Main(string[] args)
        {
            ReverseAndAdd reverseAndAdd = new ReverseAndAdd();
            string fileName = args[0];
            string[] numbersFromFile;
            string forward;
            Palindrome palindrome;

            try
            {
                numbersFromFile = reverseAndAdd.ReadFromFile(fileName);
                foreach(var number in numbersFromFile)
                {
                    forward = number;
                    palindrome = reverseAndAdd.FindPalindrome(forward);
                    reverseAndAdd.PrintPalindrome(palindrome);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
