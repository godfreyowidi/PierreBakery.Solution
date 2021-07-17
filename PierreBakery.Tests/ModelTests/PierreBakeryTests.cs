using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
  [TestMethod]
  public void CalcBreadCost_ReturnCostOfOneBread_5()
  {
    BreadQuantity testBreadCost = new BreadQuantity(1);
    Assert.AreEqual(5, testBreadCost.CalcBreadCost(1));
  }

  [TestMethod]
  public void CalcBreadCost_ReturnCostOfThreeBreads_15()
  {
    BreadQuantity testBreadCost = new BreadQuantity(3);
    Assert.AreEqual(15, testBreadCost.CalcBreadCost(3));
  }

  [TestMethod]
  public void CalcBreadCost_ReturnCostOfSixBread_6()
  {
    BreadQuantity testBreadCost = new BreadQuantity(6);
    Assert.AreEqual(15, testBreadCost.CalcBreadCost(6));
  }
  }

  [TestClass]

  public class PastryTests
  {
    [TestMethod]
    public void CalcPastryCost_ReturnCostOfOnePastry_2()
  {
    PastryQuantity testBreadCost = new PastryQuantity(1);
    Assert.AreEqual(2, testBreadCost.CalcPastryCost(1));
  }

  [TestMethod]
    public void CalcPastryCost_CostOfMultipleOfThreeOrderPastry_15()
  {
    PastryQuantity testBreadCost = new PastryQuantity(9);
    Assert.AreEqual(15, testBreadCost.CalcPastryCost(9));
  }
  }
}
