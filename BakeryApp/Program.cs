using System;
using BakeryApp.Models;

class Program
{
    static void Main()
    {
        int breadQuantity;
        Console.Write("Enter the quantity of Bread: ");
        bool isValidBreadInput = int.TryParse(Console.ReadLine(), out breadQuantity);

        if (!isValidBreadInput)
        {
            Console.WriteLine("Invalid input for Bread quantity. Please enter a valid number.");
        }

        int pastryQuantity;
        Console.Write("Enter the quantity of Pastry: ");
        bool isValidPastryInput = int.TryParse(Console.ReadLine(), out pastryQuantity);

        if (!isValidPastryInput)
        {
            Console.WriteLine("Invalid input for Pastry quantity. Please enter a valid number.");
        }

        Bread bread = new Bread();
        bread.Quantity = breadQuantity;

        Pastry pastry = new Pastry();
        pastry.Quantity = pastryQuantity;

        Console.WriteLine($"Total Cost for Bread: ${bread.CalculateBreadCost()}");
        Console.WriteLine($"Total Cost for Pastry: ${pastry.CalculatePastryCost()}");
    }
}
