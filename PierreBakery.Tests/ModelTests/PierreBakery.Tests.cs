using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]

  public class BreadTests
  {
    [TestMethod]
    public void BreadQuantity_CreatesInstanceOfBread_Bread()
    {
      BreadQuantity newBread = new BreadQuantity(1);
      Assert.AreEqual(typeof(BreadQuantity),newBread.GetType());
    }
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
  
    [TestMethod]
    public void CalcBreadCost_CostOfOddNumberBreadOrder_25()
    {
    BreadQuantity testBreadCost = new BreadQuantity(5);
    Assert.AreEqual(25, testBreadCost.CalcBreadCost(5));
    }
  
  }
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void CalcPastryCost_CostOfOnePastry_2()
    {
      PastryQuantity testPastryCost = new PastryQuantity(1);
      Assert.AreEqual(2, testPastryCost.CalcPastryCost(1));
    }

    [TestMethod]
    public void CalcPastryCost_CostOfMultiplesOfThreePastryOrder_10()
    {
      PastryQuantity testPastryCost = new PastryQuantity(6);
      Assert.AreEqual(10, testPastryCost.CalcPastryCost(6));
    }

    [TestMethod]
    public void CalcPastryCost_CostOfFivePastryOrder_9()
    {
      PastryQuantity testPastryCost = new PastryQuantity(5);
      Assert.AreEqual(9, testPastryCost.CalcPastryCost(5));
    }

    [TestMethod]
    public void CalcPastryCost_CostOfFourPastryOrder_7()
    {
      PastryQuantity testPastryCost = new PastryQuantity(4);
      Assert.AreEqual(7, testPastryCost.CalcPastryCost(4));
    }
  }
}
