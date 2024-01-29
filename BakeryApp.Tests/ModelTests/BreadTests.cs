using System;
using System.IO;
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
      Assert.AreEqual(10, bread.CalculateBreadCost());
    }

    [TestMethod]
    public void GetBreadDeal_RunBreadCalculation_Equals20()
    {
      Bread bread = new Bread();
      bread.Quantity = 6;
      Assert.AreEqual(20, bread.CalculateBreadCost());
    }

    [TestMethod]
    public void GetUserInput_OutputCost_String()
    {
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            Console.SetIn(new StringReader("3\n4\n"));

            Bread bread = new Bread();

            bread.Quantity = 3;

            int totalCost = bread.CalculateBreadCost();

            Console.WriteLine($"Total Cost: {totalCost}");

            string output = stringWriter.ToString().Trim();

            Assert.AreEqual("Total Cost: 10", output);
    }
  }
}