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
            else return '2';
        }

        private bool IsOcr1(char[,] OcrDigitToCheck)
        {
            bool result;
            char[,] ocr1 = new char[3,3]
            {
                {' ',' ',' '},
                {' ',' ','|'},
                {' ',' ','|'}   
            };
            result = AreOcrDigitsEqual(OcrDigitToCheck, ocr1);
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
