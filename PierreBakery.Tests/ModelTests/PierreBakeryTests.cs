using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]

  public class BreadTests
  {
    [TestMethod]

    public void CalcBreadCost_CostOfOneBread_5()
    {
      BreadQuantity testBreadCost = new BreadQuantity(1);
      Assert.AreEqual(5, testBreadCost.CalcBreadCost(1));
    }
    [TestMethod]
    public void CalcBreadCost_CostOfEveryTwoBreadOrder_10()
    {
    BreadQuantity testBreadCost = new BreadQuantity(3);
    Assert.AreEqual(10, testBreadCost.CalcBreadCost(3));
  }
  }
}
