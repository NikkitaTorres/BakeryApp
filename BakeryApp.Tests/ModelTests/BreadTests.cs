using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApp.Models;

namespace BakeryApp.Tests
{
  [TestClass]
  public class BreadTests
  {
    
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread bread = new Bread();
      Assert.IsNotNull(bread);
    }

    [TestMethod]
    public void GetBreadQuantity_CheckDefaultQuantity_0()
    {
      Bread bread = new Bread();
      Assert.AreEqual(0, bread.Quantity);
    }

    [TestMethod]
    public void GetBreadCost_RunBreadCalculation_Equals10()
    {
      Bread bread = new Bread();
      bread.Quantity = 3;
      Assert.AreEqual(10, bread.CalculateTotalCost());
    }
  }
}