using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombo.Models;

namespace CoinCombo.Tests
{
  [TestClass]
  public class CoinsTest
  {
    [TestMethod]
    public void QuarterClass_ReturnsOneQuarterAmount_Quarter()
    {
      Coin newQuarter = new Coin();
      Assert.AreEqual(typeof(Coin), newQuarter.GetType());
    }
  }
}
