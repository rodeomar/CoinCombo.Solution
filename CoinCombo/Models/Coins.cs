using System.Collections.Generic;
using System;


namespace CoinCombo.Models
{
  public class Coin {
    public static List<string> Piggybank { get; set; } = new List<string> {};
    public void Quarter(float amount)
    {
      int quotient = (int)(Math.Floor(amount / 0.25F));
      Piggybank.Add(quotient.ToString() + " quarters");
    }
  }
}
