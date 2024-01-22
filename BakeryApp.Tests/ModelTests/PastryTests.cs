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
    public void GetPastryQuantity_CheckDefaultQuantity_0()
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(0, pastry.Quantity);
    }
  }
}