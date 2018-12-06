using System;

namespace CSharpIntermediate
{
    class Point
    {
        private int X { get; set; }
        private int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(Point location)
        {
            if (location == null)
                throw new ArgumentNullException("location", "Point object passed to location cannot be null");

            Move(location.X, location.Y);
        }

        public override string ToString()
        {
            return $"x:{X} - y:{Y}";
        }
    }
}
