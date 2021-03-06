﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KataBankOCR.Shared;

namespace KataBankOCR.Code
{
    public class KataCode
    {

        OcrConstants ocrConstants = new OcrConstants();

        public char ConvertOCRtoDigit(string[] ocrInput)
        {
            if (IsOcr1(ocrInput) == true)
                return '1';
            if (IsOcr2(ocrInput) == true)
                return '2';
            if (IsOcr3(ocrInput) == true)
                return '3';
            if (IsOcr4(ocrInput) == true)
                return '4';
            if (IsOcr5(ocrInput) == true)
                return '5';
            if (IsOcr6(ocrInput) == true)
                return '6';
            if (IsOcr7(ocrInput) == true)
                return '7';
            if (IsOcr8(ocrInput) == true)
                return '8';
            if (IsOcr9(ocrInput) == true)
                return '9';

            return '0';
        }

        private bool IsOcr9(string[] ocrInput)
        {
            bool result;
            var ocr9 = ocrConstants.Ocr9;
            result = AreOcrDigitsEqual(ocrInput, ocr9);
            return result;
        }

        private bool IsOcr8(string[] ocrInput)
        {
            bool result;
            var ocr8 = ocrConstants.Ocr8;
            result = AreOcrDigitsEqual(ocrInput, ocr8);
            return result;
        }

        private bool IsOcr7(string[] ocrInput)
        {
            bool result;
            var ocr7 = ocrConstants.Ocr7;
            result = AreOcrDigitsEqual(ocrInput, ocr7);
            return result;
        }

        private bool IsOcr6(string[] ocrInput)
        {
            bool result;
            var ocr6 = ocrConstants.Ocr6;
            result = AreOcrDigitsEqual(ocrInput, ocr6);
            return result;
        }

        private bool IsOcr5(string[] ocrInput)
        {
            bool result;
            var ocr5 = ocrConstants.Ocr5;
            result = AreOcrDigitsEqual(ocrInput, ocr5);
            return result;
        }

        private bool IsOcr4(string[] ocrInput)
        {
            bool result;
            var ocr4 = ocrConstants.Ocr4;
            result = AreOcrDigitsEqual(ocrInput, ocr4);
            return result;
        }

        private bool IsOcr3(string[] ocrInput)
        {
            bool result;
            var ocr3 = ocrConstants.Ocr3;
            result = AreOcrDigitsEqual(ocrInput, ocr3);
            return result;
        }

        private bool IsOcr2(string[] ocrInput)
        {
            bool result;
            var ocr2 = ocrConstants.Ocr2;
            result = AreOcrDigitsEqual(ocrInput, ocr2);
            return result;
        }

        private bool IsOcr1(string[] ocrInput)
        {
            bool result;
            var ocr1 = ocrConstants.Ocr1;
            
            result = AreOcrDigitsEqual(ocrInput, ocr1);
            return result;
        }

        private static bool AreOcrDigitsEqual(string[] ocrInput, string[] ocrToTestAgainst)
        {
            bool areEqual;
            for (int x = 0; x < ocrInput.Length; x++)
            {
                areEqual = String.Equals(ocrInput[x], ocrToTestAgainst[x]);
                if (areEqual == false)
                    return false;
            }

            return true;
        }

        public string ConvertOcrAccountNumberToDigitAccountNumber(string[][] ocrAccountNumber)
        {
            string result = "";

            for (int i = 0; i < ocrAccountNumber.Length; i++)
            {
                result += ConvertOCRtoDigit(ocrAccountNumber[i]);
            }

            return result;
        }

        private string[][] ConvertOcrAccountStringToArrayOfOcrNumbers(string[] ocrAccountString)
        {
            string[] ocrDigit = new string[3];
            string[][] ocrAccountNumber = new string[9][];


            for (int i = 0; i < 9; i++)
            {
                int position = i * 3;
                ocrDigit[0] = ocrAccountString[0].Substring(position, 3);
                ocrDigit[1] = ocrAccountString[1].Substring(position, 3);
                ocrDigit[2] = ocrAccountString[2].Substring(position, 3);
                ocrAccountNumber[i] = ocrDigit;
                ocrDigit = new string[3];
            }
           
            return ocrAccountNumber;
        }


        public string OcrAccountStringToDigitalAccountNumber(string[] ocrAccountNumber)
        {
            string result = string.Empty;
            string[][] ocrDigitAccountNumber;

            ocrDigitAccountNumber = ConvertOcrAccountStringToArrayOfOcrNumbers(ocrAccountNumber);
            result = ConvertOcrAccountNumberToDigitAccountNumber(ocrDigitAccountNumber);

            return result;
        }

        private string[][] TurnOcrAccountNumberListIntoOcrAccountNumbers(string[] inputFromFile)
        {
            int numOfAccountNumbers = (inputFromFile.Length / 4);
            string[][] ocrAccountNumberSet = new string[numOfAccountNumbers][];
            string[] singleOcrAccountNumber = new string[3];

            for (int i = 0, j = 0; i < inputFromFile.Length; i += 4, j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    singleOcrAccountNumber[k] = inputFromFile[i + k];
                }
                ocrAccountNumberSet[j] = singleOcrAccountNumber;
                singleOcrAccountNumber = new string[3];
            }

            return ocrAccountNumberSet;
        }

        public string[] TurnFileContentsIntoDigitalAccountNumbers(string[] inputFromFile)
        {
            int numberOfAccounts = inputFromFile.Length;
            string[][] ocrAccountNumberSet;

            ocrAccountNumberSet = TurnOcrAccountNumberListIntoOcrAccountNumbers(inputFromFile);

            var result = new string[ocrAccountNumberSet.Length];

            for (int i = 0; i < ocrAccountNumberSet.Length; i++)
            {
                result[i] = OcrAccountStringToDigitalAccountNumber(ocrAccountNumberSet[i]);
            }

            return result;
        }

        public string[] TurnFileIntoDigitalAccountNumbers(string fileName)
        {
            string[] inputFromFile;
            string[] listOfDigitalAccountNumbers;

            inputFromFile = TurnFileIntoArrayOfStrings(fileName);
            listOfDigitalAccountNumbers = TurnFileContentsIntoDigitalAccountNumbers(inputFromFile);
            return listOfDigitalAccountNumbers;
        }

        private string[] TurnFileIntoArrayOfStrings(string fileName)
        {
            string[] result;

                result = System.IO.File.ReadAllLines(fileName);

            return result;
        }

        public bool IsCheckSumValid(string accountNumber)
        {
            int compareCheckSumTo = 0;
            int checkSum;
            checkSum = CalculateChecksum(accountNumber);

            if (checkSum == compareCheckSumTo)
                return true;
            else
                return false;
            
        }

        private static int CalculateChecksum(string accountNumber)
        {
            int checkSum;
            int placeholder = 0;
            char[] reversedAccountNumberArray;
            int accountInt;

            reversedAccountNumberArray = accountNumber.ToCharArray();
            Array.Reverse(reversedAccountNumberArray);
            accountInt = Convert.ToInt32(accountNumber);

            for (int i = 0; i < 9; i++)
            {
                placeholder += Int32.Parse(reversedAccountNumberArray[i].ToString()) * (i + 1);
            }

            checkSum = placeholder % 11;
            return checkSum;
        }

        

    }
}
