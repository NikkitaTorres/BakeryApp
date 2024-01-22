using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApp.Models;

namespace BakeryApp.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastry = new Pastry();
      Assert.IsNotNull(pastry);
    }

    [TestMethod]
    public void GetPastryCost_RunPastryCalculation_Equals10()
    {
      Pastry pastry = new Pastry();
      pastry.Quantity = 4;
      Assert.AreEqual(6, pastry.CalculateTotalCost());
    }
  }
}