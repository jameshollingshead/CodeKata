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
                return ConvertMoneyToString();
            }
        }

        private string ConvertMoneyToString()
        {
            return "$" + string.Format("{0:0.00}", total);
        }

        public void InsertCoin(string coin)
        {
            total = GetCoinValue(coin);
        }

        private double GetCoinValue(string coin)
        {
            double result;
            switch (coin.ToLower())
            {
                case "dime":
                    result = 0.10;
                    break;
                case "nickel":
                    result = 0.05;
                    break;
                case "quarter":
                    result = 0.25;
                    break;
                default:
                    result = 0.00;
                    break;
            }
            return result;

        }
    }
}
