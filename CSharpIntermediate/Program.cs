using System;
using NUnit.Framework;
using NUnit.Framework.Tests;

namespace CSharpIntermediate
{
  partial class Program
  {
    static void Main(string[] args)
    {
      // Anatomy of a class: Data and Methods
      // Class Name
      // Data Names and types
      // Method Names

      // e.g.
      // Post
      // Title: string
      // Publish()

      // Object is an instance of a class that resides in memory

      var orderProcessor = new OrderProcessor(new ShippingCalculator());
      var order = new Order {DatePlaced = DateTime.Now, TotalPrice = 100f};
      orderProcessor.Process(order);

      OrderProcessorTests test = new OrderProcessorTests();

      test.Process_OrderIsAlreadyShippinged_ThrowsAnException();

      // object empinada = "dingo";

      // // Classic syntax
      // Assert.IsNull(empinada);

      // // Constraint Syntax
      // Assert.That(empinada, Is.Null);
    }
  }
}
