using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombo.Models;

namespace CoinCombo.Tests
{
  [TestClass]
  public class CoinsTest
  {
    [TestMethod]
    public void CoinClass_CreatesNewCoin_Coin()
    {
      Coin newQuarter = new Coin();
      Assert.AreEqual(typeof(Coin), newQuarter.GetType());
    }

    // [TestMethod]
    // public void QuarterMethod_ReturnsQuarterValue_Quarter()
    // {
    //   Coin newQuarter = new Coin();
    //   float expected = 0.25F;
    //   float quarter = newQuarter.Quarter(expected);
    //   Assert.AreEqual(expected, quarter);
    // }
    // [TestMethod]
    // public void QuarterMethod_ReturnsFloatAmount_Quarter()
    // {
    //   Coin newQuarter = new Coin();
    //   int expected = 1;
    //   float amount = 0.25F;
    //   Assert.AreEqual(expected, newQuarter.Quarter(amount));

    // }
    // [TestMethod]
    // public void QuarterMethod_MathOutputsCorrectNumber_Quarter()
    // {
    //   Coin newQuarter = new Coin();
    //   int expected = 3;
    //   float amount = 0.75F;
    //   Assert.AreEqual(expected, newQuarter.Quarter(amount));
    // }
    // [TestMethod]
    // public void QuarterMethod_ReturnsStringQuarterAmount_Quarter()
    // {
    //   Coin newQuarter = new Coin();
    //   string expected = "3 quarters";
    //   float amount = 0.75F;
    //   Assert.AreEqual(expected, newQuarter.Quarter(amount));
    // }
    [TestMethod]
    public void QuarterMethod_AddsQuartersToList_String()
    {
      Coin newQuarter = new Coin();
      string expected = "3 quarters";
      float amount = 0.75F;
      newQuarter.Quarter(amount);
      Assert.AreEqual(expected, Coin.Piggybank[0]);
    }
  }
}
