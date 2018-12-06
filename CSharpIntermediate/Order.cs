using System;

namespace CSharpIntermediate
{
  public class Order
  {
      public int Id { get; set; }
    public bool IsShipped
    {
      get { return Shipment != null; }
    }
    public DateTime DatePlaced { get; set; }
    public float TotalPrice { get; set; }
    public Shipment Shipment { get; set; }


    public Order() { }
    public void Process(Order newOrder)
    {
      System.Console.WriteLine(newOrder);
    }

  }
}