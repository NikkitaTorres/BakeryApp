using System;
using System.IO;
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

    [TestMethod]
    public void GetPastryCost_RunPastryCalculation_Equals6()
    {
      Pastry pastry = new Pastry();
      pastry.Quantity = 4;
      Assert.AreEqual(6, pastry.CalculateTotalCost());
    }

    [TestMethod]
    public void GetPastryDeal_RunPastryCalculation_Equals12()
    {
      Pastry pastry = new Pastry();
      pastry.Quantity = 8;
      Assert.AreEqual(12, pastry.CalculateTotalCost());
    }

    [TestMethod]
    public void GetUserInput_OutputCost_String()
    {
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            Console.SetIn(new StringReader("4\n5\n"));

            Pastry pastry = new Pastry();

            pastry.Quantity = 4;

            int totalCost = pastry.CalculateTotalCost();

            // Print the total cost to the console 
            Console.WriteLine($"Total Cost: {totalCost}");

            // Get the console output
            string output = stringWriter.ToString().Trim();

            // Assert the expected output
            Assert.AreEqual("Total Cost: 6", output);
    }
  }
}