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
      Assert.AreEqual(10, bread.CalculateTotalCost());
    }

    [TestMethod]
    public void GetBreadDeal_RunBreadCalculation_Equals20()
    {
      Bread bread = new Bread();
      bread.Quantity = 6;
      Assert.AreEqual(20, bread.CalculateTotalCost());
    }

    [TestMethod]
    public void GetUserInput_OutputCost_String()
    {
      // Redirect Console.Out to a StringWriter
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Set up user input
            Console.SetIn(new StringReader("3\n4\n"));

            // Instantiate the Bread object
            Bread bread = new Bread();

            // Set the quantity
            bread.Quantity = 3;

            // Call the method that calculates the total cost
            int totalCost = bread.CalculateTotalCost();

            // Print the total cost to the console (or use the actual method from your application)
            Console.WriteLine($"Total Cost: {totalCost}");

            // Get the console output
            string output = stringWriter.ToString().Trim();

            // Assert the expected output
            Assert.AreEqual("Total Cost: 10", output);
    }
  }
}