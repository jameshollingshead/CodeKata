using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataBankOCR.Shared
{
    public class OcrConstants
    {
        private string[] _ocr1 = 
        {
            "   ",
            "  |",
            "  |"
        };

        private string[] _ocr2 = 
        {
            " _ ",
            " _|",
            "|_ "
        };

        private string[] _ocr3 = 
        {
            " _ ",
            " _|",
            " _|"
        };

        private string[] _ocr4 = 
        {
            "   ",
            "|_|",
            "  |"
        };

        private string[] _ocr5 = 
        {
            " _ ",
            "|_ ",
            " _|"
        };

        private string[] _ocr6 = 
        {
            " _ ",
            "|_ ",
            "|_|"
        };

        private string[] _ocr7 = 
        {
            " _ ",
            "  |",
            "  |"
        };

        private string[] _ocr8 = 
        {
            " _ ",
            "|_|",
            "|_|"
        };

        private string[] _ocr9 = 
        {
            " _ ",
            "|_|",
            " _|"
        };

        private string[] _ocr0 = 
        {
            " _ ",
            "| |",
            "|_|"
        };



        public string[] Ocr1
        {
            get { return _ocr1; }
        }

        public string[] Ocr2
        {
            get { return _ocr2; }
        }

        public string[] Ocr3
        {
            get { return _ocr3; }
        }

        public string[] Ocr4
        {
            get { return _ocr4; }
        }

        public string[] Ocr5
        {
            get { return _ocr5; }
        }

        public string[] Ocr6
        {
            get { return _ocr6; }
        }

        public string[] Ocr7
        {
            get { return _ocr7; }
        }

        public string[] Ocr8
        {
            get { return _ocr8; }
        }

        public string[] Ocr9
        {
            get { return _ocr9; }
        }

        public string[] Ocr0
        {
            get { return _ocr0; }
        }
    }
}
