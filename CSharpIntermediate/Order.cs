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
    private double Price { get; set; }

    public Order() { }
    public Order(int id, float price)
    {
        Id = id;
        Price = price;
    }
    public void Process(Order newOrder)
    {
      System.Console.WriteLine(newOrder);
    }

  }
}