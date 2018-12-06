using System;
using NUnit.Framework;

namespace CSharpIntermediate
{
  partial class Program
  {
    public class OrderProcessorTests
    {
      [Test]
      public void Process_OrderIsAlreadyShippinged_ThrowsAnException()
      {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order
        {
          Shipment = new Shipment()
        };

        Assert.Throws<InvalidOperationException>(() => orderProcessor.Process(order));
      }

      [Test]
      public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
      {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order();

        orderProcessor.Process(order);
        Assert.IsTrue(order.IsShipped);
        Assert.AreEqual(1, order.Shipment.Cost);
        Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
      }
    }
  }
}
