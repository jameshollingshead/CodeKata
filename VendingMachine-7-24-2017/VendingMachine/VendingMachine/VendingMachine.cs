using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachines
{
    public class VendingMachine
    {
        private double total = 0.0;

        public String GetDisplay()
        {
            if (total == 0)
            {
                return "Insert Coin";
            }
            else
            {
                return "$0.10";
            }
        }

        public void InsertCoin(string coin)
        {
            total = 0.10;
        }
    }
}
