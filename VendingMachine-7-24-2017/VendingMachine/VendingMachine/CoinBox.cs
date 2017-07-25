using System.Collections.Generic;

namespace VendingMachines
{
    public class CoinBox
    {
        public bool IsValidCoin(string coin)
        {
            var validCoins = new List<string> { "nickel", "dime", "quarter" };
            return validCoins.Contains(coin.ToLower());
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

        public double GetCoinValue(string coin)
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
    }
}