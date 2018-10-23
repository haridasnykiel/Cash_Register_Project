using System;
using Cash_Register_Core;
namespace Cash_Register_User {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("\nWelcome to the Cash Register Program");
            Console.WriteLine ("\n====================================");
            Console.WriteLine ("\n\nInput Price of item.");
            decimal price = Convert.ToDecimal (Console.ReadLine ());
            Console.WriteLine ("\nInput customer cash.");

            decimal cash = Convert.ToDecimal (Console.ReadLine ());

            Console.WriteLine ("\n\n====================================");
            var cashRegister = new CashRegister (price, cash);
            if (price > cash)
                Console.WriteLine (cashRegister.ERROR);
            else {
                Console.WriteLine ("Cash to return: " + cashRegister.CashToReturn ().ToString () + "\n");
                Console.WriteLine (cashRegister.RemoveEmptyLines("Change:\n" + cashRegister.CalculateChange ()));
            }

        }
    }
}