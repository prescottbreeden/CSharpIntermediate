namespace CSharpIntermediate
{
    internal class Order
    {
        private int Id { get; set; }
        private double Price { get; set; }

        public Order() { }

        public Order(int id, double price)
        {
            Id = id;
            Price = price;
        }

        public override string ToString()
        {
            return $"Order Id: {Id}, Price: {Price}";
        }
    }
}