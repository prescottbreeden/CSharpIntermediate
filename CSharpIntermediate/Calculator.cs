namespace CSharpIntermediate
{
    class Calculator
    {
        private int Total { get; set; }

        public Calculator()
        {
            Total = 0;
        }

        public int Add(params int[] numbers)
        {
            Total = 0;
            foreach (int num in numbers)
                Total += num;

            return Total;
        }
    }
}
