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
      Assert.NotNull(bread);
    }
  }
}