using System;
using System.Collections.Generic;
using System.Text;

namespace Cash_Register_Core {
    public class CashRegister {

        public const decimal PENNY = 00.01M;
        public const decimal NICKEL = 00.05M;
        public const decimal DIME = 00.10M;
        public const decimal QUARTER = 00.25M;
        public const decimal HALF_DOLLAR = 00.50M;
        public const decimal ONE = 01.00M;
        public const decimal TWO = 02.00M;
        public const decimal FIVE = 05.00M;
        public const decimal TEN = 10.00M;
        public const decimal TWENTY = 20.00M;
        public const decimal FIFTY = 50.00M;
        public const decimal ONE_HUNDRED = 100.00M;

        private decimal _price;
        private decimal _cash;

        public CashRegister (decimal price, decimal cash) {
            _price = price;
            _cash = cash;
        }

        public string ERROR {
            get {
                return _price > _cash ? "ERROR" : null;
            }
        }

        public decimal CashToReturn () {
            if (_price == _cash) {
                return 0M;
            } else {
                return _cash - _price;
            }
        }

        public string CalculateChange () {
            var changeToReturn = CashToReturn ();
            StringBuilder stringBuilder = new StringBuilder ();
            stringBuilder.AppendLine (Calculator (changeToReturn, ONE_HUNDRED, "ONE_HUNDRED"));
            stringBuilder.AppendLine (Calculator (changeToReturn, FIFTY, "FIFTY"));
            stringBuilder.AppendLine (Calculator (changeToReturn, TWENTY, "TWENTY"));
            stringBuilder.AppendLine (Calculator (changeToReturn, TEN, "TEN"));
            stringBuilder.AppendLine (Calculator (changeToReturn, FIVE, "FIVE"));
            stringBuilder.AppendLine (Calculator (changeToReturn, TWO, "TWO"));
            stringBuilder.AppendLine (Calculator (changeToReturn, ONE, "ONE"));
            stringBuilder.AppendLine (Calculator (changeToReturn, HALF_DOLLAR, "HALF_DOLLAR"));
            stringBuilder.AppendLine (Calculator (changeToReturn, TWENTY, "TWENTY"));
            stringBuilder.AppendLine (Calculator (changeToReturn, QUARTER, "QUARTER"));
            stringBuilder.AppendLine (Calculator (changeToReturn, DIME, "DIME"));
            stringBuilder.AppendLine (Calculator (changeToReturn, NICKEL, "NICKEL"));
            stringBuilder.AppendLine (Calculator (changeToReturn, PENNY, "PENNY"));
            return stringBuilder.ToString();
        }

        public string Calculator (decimal changeToReturn, decimal coin, string coinName) {
            int count = 0;
            while (changeToReturn <= coin) {
                count++;
            }
            if (count == 0)
                return "";
            return $"{coinName} = {count}";
        }

    }

}
