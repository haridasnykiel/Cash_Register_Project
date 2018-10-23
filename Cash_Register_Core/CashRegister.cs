using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
                return _price > _cash ? "Customer is short" : null;
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
            stringBuilder.AppendLine (Calculator (changeToReturn, ONE_HUNDRED, "ONE_HUNDRED", out changeToReturn));
            stringBuilder.AppendLine (Calculator (changeToReturn, FIFTY, "FIFTY", out changeToReturn));
            stringBuilder.AppendLine (Calculator (changeToReturn, TWENTY, "TWENTY", out changeToReturn));
            stringBuilder.AppendLine (Calculator (changeToReturn, TEN, "TEN", out changeToReturn));
            stringBuilder.AppendLine (Calculator (changeToReturn, FIVE, "FIVE", out changeToReturn));
            stringBuilder.AppendLine (Calculator (changeToReturn, TWO, "TWO", out changeToReturn));
            stringBuilder.AppendLine (Calculator (changeToReturn, ONE, "ONE", out changeToReturn));
            stringBuilder.AppendLine (Calculator (changeToReturn, HALF_DOLLAR, "HALF_DOLLAR", out changeToReturn));
            stringBuilder.AppendLine (Calculator (changeToReturn, TWENTY, "TWENTY", out changeToReturn));
            stringBuilder.AppendLine (Calculator (changeToReturn, QUARTER, "QUARTER", out changeToReturn));
            stringBuilder.AppendLine (Calculator (changeToReturn, DIME, "DIME", out changeToReturn));
            stringBuilder.AppendLine (Calculator (changeToReturn, NICKEL, "NICKEL", out changeToReturn));
            stringBuilder.AppendLine (Calculator (changeToReturn, PENNY, "PENNY", out changeToReturn));

            return stringBuilder.ToString ();
        }

        public string Calculator (decimal changeToReturn, decimal coin, string coinName,
            out decimal decimalLeftOverChange) {
            int count = 0;
            while (changeToReturn >= coin) {
                count++;
                changeToReturn -= coin;
            }
            decimalLeftOverChange = changeToReturn;
            if (count == 0)
                return null;
            return $"{coinName} = {count}";
        }

        public string RemoveEmptyLines (string lines) {
            return Regex.Replace (lines, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd ();
        }

    }

}