using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Customer
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            Name = name;
        }

        public void Promote()
        {
           // ... 
           // Orders = new List<Order>(); <~~ cannot accidentally re-initialize because porperty is read only
        }

        public void Print()
        {
            System.Console.WriteLine(Id);
            System.Console.WriteLine(Name);
            if (Orders.Count > 0)
            {
                foreach (Order o in Orders)
                    System.Console.WriteLine(o);
            }
            else
            {
                System.Console.WriteLine("{0} has no Orders", Name);
            }
        }

        public void NewOrder(int id, double price)
        {
            var newOrder = new Order(id, price);
            Orders.Add(newOrder);
        }
    }
}
