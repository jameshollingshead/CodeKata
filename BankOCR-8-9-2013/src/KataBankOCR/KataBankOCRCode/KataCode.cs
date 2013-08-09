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
            if (IsOCR1(ocrInput) == true)
                return '1';
            else return '2';
        }

        private bool IsOCR1(char[,] OcrDigitToCheck)
        {
            
            char[,] ocr1 = new char[3,3]
            {
                {' ',' ',' '},
                {' ',' ','|'},
                {' ',' ','|'}   
            };

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if(OcrDigitToCheck[x,y] != ocr1[x,y])
                        return false;
                }
            }

            return true;
        }
    }
}
