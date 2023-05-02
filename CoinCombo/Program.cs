using System;
using System.Collections.Generic;
using CoinCombo.Models;

namespace CoinCombo
{
    class Program
    {
        static void Main()
        {
          RunApp();
        }
        public static void RunApp()
        {
          Console.WriteLine("Welcome to our Change Maker");
          Console.WriteLine("Enter a Dolla amount(EG: '1.37')");
          string userAmount = Console.ReadLine();
          Console.WriteLine("Calculating...");
          Console.WriteLine("The results are in!!!!!!");
          try
          {
            decimal amount = Convert.ToDecimal(userAmount);
            Coin change = new Coin();
            change.Quarter(amount);
            List<string> changeDue = Coin.Piggybank;
            foreach (string coin in changeDue)
            {
              Console.WriteLine(coin);
            }
            TryAgain();
          }
          catch
          {
            Console.WriteLine("!!!!!!!!!!!!!!!!");
            Console.WriteLine("Error: Please only enter numbers with up to two decimal places, i.e. '5.45' or '65.09'");
            TryAgain();
          }
        }
        public static void TryAgain()
        {
          Console.WriteLine("Try again? (Y/N)");
          Console.Beep();
          string answer = Console.ReadLine();
          if (answer.ToUpper() == "Y")
          {
            RunApp();
          }
          else
          {
            Console.WriteLine("Goodbye!");
          }
        }
    }
}
