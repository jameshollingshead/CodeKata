﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataBankOCR.Code
{
    public class KataCode
    {

        public char ConvertOCRtoDigit(char[,] ocrInput)
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

            else return ' ';
        }

        private bool IsOcr5(char[,] ocrInput)
        {
            bool result;
            char[,] ocr5 = new char[3, 3]
            {
                {' ','_',' '},
                {'|','_',' '},
                {' ','_','|'}
            };
            result = AreOcrDigitsEqual(ocrInput, ocr5);
            return result;
        }

        private bool IsOcr4(char[,] ocrInput)
        {
            bool result;
            char[,] ocr4 = new char[3, 3]
            {
                {' ',' ',' '},
                {'|','_','|'},
                {' ',' ','|'},
            };
            result = AreOcrDigitsEqual(ocrInput, ocr4);
            return result;
        }

        private bool IsOcr3(char[,] ocrInput)
        {
            bool result;
            char[,] ocr3 = new char[3, 3]
            {
                {' ','_',' '},
                {' ','_','|'},
                {' ','_','|'}
            };
            result = AreOcrDigitsEqual(ocrInput, ocr3);
            return result;
        }

        private bool IsOcr2(char[,] ocrInput)
        {
            bool result;
            char[,] ocr2 = new char[3, 3]
            {
                {' ','_',' '},
                {' ','_','|'},
                {'|','_',' '}
            };
            result = AreOcrDigitsEqual(ocrInput, ocr2);
            return result;
        }

        private bool IsOcr1(char[,] ocrInput)
        {
            bool result;
            char[,] ocr1 = new char[3,3]
            {
                {' ',' ',' '},
                {' ',' ','|'},
                {' ',' ','|'}   
            };
            result = AreOcrDigitsEqual(ocrInput, ocr1);
            return result;
        }

        private static bool AreOcrDigitsEqual(char[,] ocrInput, char[,] ocrToTestAgainst)
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (ocrInput[x, y] != ocrToTestAgainst[x, y])
                        return false;
                }
            }

            return true;
        }
    }
}
