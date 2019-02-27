using System.Collections.Generic;

namespace VendingMachines
{
    public class CoinBox
    {
        private double _insertedCoins;

        public double InsertedCoins()
        {
            return _insertedCoins;
        }

        public void AddCoin(string coin)
        {
            _insertedCoins += GetCoinValue(coin);
        }

        public bool IsValidCoin(string coin)
        {
            var validCoins = new List<string> { "nickel", "dime", "quarter" };
            return validCoins.Contains(coin.ToLower());
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

    }
}