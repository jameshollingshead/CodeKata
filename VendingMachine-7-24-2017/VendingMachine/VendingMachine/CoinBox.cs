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

        public bool IsPenny(string coin)
        {
            return coin.ToLower() == "penny";
        }

        public bool IsQuarter(string coin)
        {
            return coin.ToLower() == "quarter";
        }

        public bool IsDime(string coin)
        {
            return coin.ToLower() == "dime";
        }

        public bool IsNickel(string coin)
        {
            return coin.ToLower() == "nickel";
        }
   

  
        public double AddCoinToReturnedCoins(string coin, double returnedCoins)
        {
            return returnedCoins + GetCoinValue(coin);
        }

        public double AddCoinToInsertedCoins(string coin, double insertedCoins)
        {
            return insertedCoins + GetCoinValue(coin);
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
    }
}