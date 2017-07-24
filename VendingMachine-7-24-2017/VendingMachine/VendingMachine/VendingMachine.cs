using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachines
{
    public class VendingMachine
    {
        private double insertedCoins = 0.0;
        private double returnedCoins = 0.0;

        public String GetDisplay()
        {
            return insertedCoins == 0 ? "Insert Coin" : ConvertMoneyToString();
        }

        private string ConvertMoneyToString()
        {
            return "$" + string.Format("{0:0.00}", insertedCoins);
        }

        public void InsertCoin(string coin)
        {
            if(IsValidCoin(coin))
                AddCoinToInsertedCoins(coin);
            else
                AddCoinToReturnedCoins(coin);
        }

        private void AddCoinToReturnedCoins(string coin)
        {
            returnedCoins += GetCoinValue(coin);
        }

        private void AddCoinToInsertedCoins(string coin)
        {
            insertedCoins += GetCoinValue(coin);
        }

        private bool IsValidCoin(string coin)
        {
            var validCoins = new List<string> {"nickel", "dime", "quarter"};
            return validCoins.Contains(coin.ToLower());
        }

        private double GetCoinValue(string coin)
        {
            double result = 0.00;

            if (IsNickel(coin))
                result = 0.05;
            if (IsDime(coin))
                result = 0.10;
            if (IsQuarter(coin))
                result = 0.25;
            if (IsPenny(coin))
                result = 0.01;

            return result;
        }

        private bool IsPenny(string coin)
        {
            return coin.ToLower() == "penny";
        }

        private bool IsQuarter(string coin)
        {
            return coin.ToLower() == "quarter";
        }

        private bool IsDime(string coin)
        {
            return coin.ToLower() == "dime";
        }

        private bool IsNickel(string coin)
        {
            return coin.ToLower() == "nickel";
        }

        public double GetReturnedCoins()
        {
            return returnedCoins;
        }
    }
}
