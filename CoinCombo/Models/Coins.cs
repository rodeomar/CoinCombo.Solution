using System.Collections.Generic;
using System;


namespace CoinCombo.Models
{
  public class Coin {
    public static List<string> Piggybank { get; set; } = new List<string> {};
    public void Quarter(decimal amount)
    {
      decimal quarter = 0.25m;
      int quotient = (int)(Math.Floor(amount / quarter));
      Piggybank.Add(quotient.ToString() + " quarter(s)");
      decimal remainder = amount % quarter;
      remainder = Decimal.Round(remainder, 2);
      Dime(remainder); 
    }
    public decimal Dime(decimal r)
    {
      decimal dime = 0.10m;
      if (r < dime)
      {
        return r;
      }
      else 
      {
      int quotient = (int)(Math.Floor(r / dime));
      Piggybank.Add(quotient.ToString() + " dime(s)");
      decimal remainder = r % dime;
      remainder = Decimal.Round(remainder, 2);
      return remainder; 
      }
    }
        public decimal Nickel(decimal r)
    {
      decimal nickel = 0.05m;
      if (r < nickel)
      {
        return r;
      }
      else 
      {
      int quotient = (int)(Math.Floor(r / nickel));
      Piggybank.Add(quotient.ToString() + " nickel(s)");
      decimal remainder = r % nickel;
      remainder = Decimal.Round(remainder, 2);
      return remainder; 
      }
    }

    public static void ClearAll()
    {
      Piggybank.Clear();
    }
  }
}
