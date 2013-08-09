using System;
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
            if (isOcr2(ocrInput) == true)
                return '2';
            if (isOcr3(ocrInput) == true)
                return '3';

            else return ' ';
        }

        private bool isOcr3(char[,] ocrInput)
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

        private bool isOcr2(char[,] ocrInput)
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
