using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Customer
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private List<Order> Orders { get; set; }

        // too many constructors with this links - not very readable and poor to maintain
        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(string name)
            : this()
        {
            Name = name;
        }

        public Customer(int id, string name)
            : this()
        {
            Id = id;
            Name = name;
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
